using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using IdentityData;
using SchaakData;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityData;

namespace Schaak.Controllers
{
    public class ApplicationUsersController : Controller
    {
        private readonly IdContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<ApplicationRole> _roleManager;

        public ApplicationUsersController(IdContext context, UserManager<ApplicationUser> userManager, RoleManager<ApplicationRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        // [HttpPost]
        public async Task<IActionResult> SwitchAdmin(Guid Id)
        {
            if (Id == null)
            {
                return NotFound();
            }

            ApplicationUser user = _context.Users.Find(Id);
            if (await _userManager.IsInRoleAsync(user, "Administrators"))
            {
                await _userManager.RemoveFromRoleAsync(user, "Administrators");
            }
            else
            {
                await _userManager.AddToRoleAsync(user, "Administrators");
            }
            return LocalRedirect("/ApplicationUsers");
        }



        // GET: ApplicationUsers
        public IActionResult Index()
        {


            var test2 = _context.Users.Join(_context.UserRoles.DefaultIfEmpty(), a => a.Id, b => b.UserId, (a, b) => new { a.Email, RoleId = b.RoleId == null ? Guid.Empty : b.RoleId });
            var test4 = _context.UserRoles.Join(_context.Users.DefaultIfEmpty(), a => a.UserId, b => b.Id, (a, b) => new { UserId = a.UserId == null ? Guid.Empty : a.UserId, Id = b.Id == null ? Guid.Empty : b.Id, Email = b.Email == null ? string.Empty : b.Email });





            //////////// NEEDED ////////////

            List<ApplicationUser> ccc = _context.Users.Join(_context.UserRoles.DefaultIfEmpty(), a => a.Id, b => b.UserId, (a, b) => new ApplicationUser { Id = a.Id, RoleId = b.RoleId == null ? Guid.Empty : b.RoleId, FirstName = a.FirstName, LastName = a.LastName, Email = a.Email }).ToList();
            List<ApplicationUser> ddd = _context.Roles.Join(ccc.DefaultIfEmpty(), a => a.Id, b => b.RoleId, (a, b) => new ApplicationUser() { RoleId = a.Id, RoleName = a.Name, FirstName = b.FirstName, LastName = b.LastName, Email = b.Email, UserName = b.UserName, Id = b.Id }).ToList();
            var fff = _context.Roles.GroupJoin(ddd, a => a.Id, b => b.RoleId, (role, users) => new RoleUsers() { RoleName = role.Name, Users = users.ToList() });
            ViewBag.GroupJoin = fff;
            ViewBag.Join = _userManager.Users.Join(_context.UserRoles.DefaultIfEmpty(), a => a.Id, b => b.UserId, (a, b) => new { a.Id, a.FirstName, a.LastName, a.Email, b.RoleId })
                .Join(_context.Roles.DefaultIfEmpty(), a => a.RoleId, b => b.Id, (a, b) => new { a.Id, a.FirstName, a.LastName, a.Email, RoleName = b.Name })
                .Select(a => new ApplicationUser { Id = a.Id, FirstName = a.FirstName, LastName = a.LastName, Email = a.Email, Admin = (a.RoleName != null ? a.RoleName.ToUpper() == "ADMINISTRATORS" : false) }).ToList();
            return View();
        }

        // POST: ApplicationUsers/Index/ID
        // Save individual Rows
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index([Bind("Id,FirstName,LastName")] ApplicationUser applicationUser)
        {
            if (ModelState.IsValid)
            {
                if (applicationUser == null)
                {
                    return RedirectToAction(nameof(Index));
                }

                if (applicationUser.Id == null)
                {
                    return RedirectToAction(nameof(Index));
                }

                var user = _context.Users.Find(applicationUser.Id);
                user.FirstName = applicationUser.FirstName;
                user.LastName = applicationUser.LastName;
                _context.Update(user);

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(applicationUser);
        }

        // GET: ApplicationUsers/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var applicationUser = await _context.Users
                .FirstOrDefaultAsync(m => m.Id == id);
            if (applicationUser == null)
            {
                return NotFound();
            }

            return View(applicationUser);
        }

        // GET: ApplicationUsers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ApplicationUsers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FirstName,LastName,Id,UserName,NormalizedUserName,Email,NormalizedEmail,EmailConfirmed,PasswordHash,SecurityStamp,ConcurrencyStamp,PhoneNumber,PhoneNumberConfirmed,TwoFactorEnabled,LockoutEnd,LockoutEnabled,AccessFailedCount")] ApplicationUser applicationUser)
        {
            if (ModelState.IsValid)
            {
                applicationUser.Id = Guid.NewGuid();
                applicationUser.FirstName = " ";
                applicationUser.LastName = " ";
                _context.Add(applicationUser);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(applicationUser);
        }

        // GET: ApplicationUsers/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var applicationUser = await _context.Users.FindAsync(id);
            if (applicationUser == null)
            {
                return NotFound();
            }
            return View(applicationUser);
        }

        // POST: ApplicationUsers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("FirstName,LastName,Id,UserName,NormalizedUserName,Email,NormalizedEmail,EmailConfirmed,PasswordHash,SecurityStamp,ConcurrencyStamp,PhoneNumber,PhoneNumberConfirmed,TwoFactorEnabled,LockoutEnd,LockoutEnabled,AccessFailedCount")] ApplicationUser applicationUser)
        {
            if (id != applicationUser.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(applicationUser);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ApplicationUserExists(applicationUser.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(applicationUser);
        }

        // GET: ApplicationUsers/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var applicationUser = await _context.Users
                .FirstOrDefaultAsync(m => m.Id == id);
            if (applicationUser == null)
            {
                return NotFound();
            }

            return View(applicationUser);
        }

        // POST: ApplicationUsers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var applicationUser = await _context.Users.FindAsync(id);
            _context.Users.Remove(applicationUser);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ApplicationUserExists(Guid id)
        {
            return _context.Users.Any(e => e.Id == id);
        }
    }
    public class RoleUsers
    {
        public string RoleName { get; set; }
        public List<ApplicationUser> Users { get; set; }
    }
}
