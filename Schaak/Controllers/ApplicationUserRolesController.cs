using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SchaakData;
using IdentityData;
using SchaakData;
using IdentityData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityData;

namespace Schaak.Controllers
{
    public class ApplicationUserRolesController : Controller
    {
        private readonly IdContext _context;
        public string RoleName { get; private set; }
        public string UserName { get; private set; }
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<ApplicationRole> _roleManager;

        public ApplicationUserRolesController(IdContext context, UserManager<ApplicationUser> userManager, RoleManager<ApplicationRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
    }

    // GET: ApplicationUserRoles
    public async Task<IActionResult> Index()
        {
             var List = await _context.UserRoles
                .Join(_context.Users, a => a.UserId, u => u.Id, (a, us) => new { a.RoleId, a.UserId, us.UserName })
                .Join(_context.Roles, l => l.RoleId, r => r.Id, (l, r) => Tuple.Create<Guid, Guid, string, string>(l.RoleId, l.UserId, r.Name, l.UserName)).ToListAsync();
             ViewBag.List = List;
            return View();
        }

        // GET: ApplicationUserRoles/Create
        public IActionResult Create()
        {
            ViewBag.UserList = _context.Users.OrderBy(b => b.DisplayName).Select(c => new SelectListItem() { Text = $"{c.UserName}: {c.DisplayName}", Value = c.Id.ToString() });
            ViewBag.RoleList = _context.Roles.OrderBy(b => b.Name).Select(c => new SelectListItem() { Text = $"{c.Name}: {c.NormalizedName}", Value = c.Id.ToString() });
            return View();
        }

        // POST: ApplicationUserRoles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserId,RoleId")] IdentityUserRole<Guid> userRole)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser user = await _userManager.Users.Where(u => u.Id == userRole.UserId).FirstOrDefaultAsync();
                ApplicationRole role = await _roleManager.Roles.Where(u => u.Id == userRole.RoleId).FirstOrDefaultAsync();
                var result = await _userManager.AddToRoleAsync(user, role.Name);
                return RedirectToAction(nameof(Index));
            }
            return View(userRole);
        }

        public async Task<IActionResult> Delete(Guid roleId, Guid userId)
        {
            if (roleId == null || userId == null)
            {
                return NotFound();
            }
            var applicationUserRole = await _context.UserRoles
                .FirstOrDefaultAsync(m => m.UserId == userId & m.RoleId == roleId);
            if (applicationUserRole == null)
            {
                return NotFound();
            }
            ApplicationUserRole<Guid> userRole = new ApplicationUserRole<Guid>(_context, userId, roleId);       
            return View(userRole);
    }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid UserId, Guid RoleId)
        {
             IdentityUserRole<Guid> userRole = await _context.UserRoles.Where(s => s.RoleId == RoleId && s.UserId == UserId).FirstAsync();
            _context.UserRoles.Add(userRole);
            _context.Entry(userRole).State = EntityState.Deleted;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
