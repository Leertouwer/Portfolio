using IdentityData;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Schaak.Areas.Admin.Models;
using SchaakData;
using System.Linq;
using System.Threading.Tasks;

namespace Schaak.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContestentsController : Controller
    {
        private readonly ApplContext _appContext;
        private readonly IdContext _idContext;
        private readonly ILogger _logger;

        public ContestentsController(ApplContext appContext, IdContext idContext, ILogger<ContestentsController> logger)
        {
            _appContext = appContext;
            _idContext = idContext;
            _logger = logger;
        }

        // GET: Admin/Contestents
        public async Task<IActionResult> Index()
        {

            var sqlTask = Task.Run(() => from u in _idContext.Users
                                         join c in _appContext.Contestent
                                         on u.Id.ToString() equals c.UsersId
                                         join t in _appContext.Tournement
                                         on c.TournementId equals t.Id
                                         select new ContestentsListViewModel
                                         {
                                             ContestentId = c.Id,
                                             EnlistDate = c.EnlistDate,
                                             UsersId = c.UsersId,
                                             RegistrationEndDate = t.RegistrationEndDate,
                                             RegistrationStartDate = t.RegistrationStartDate,
                                             TournementEndDate = t.TournementEndDate,
                                             TournementStartDate = t.TournementStartDate,
                                             TournementName = t.Name,
                                             TournementId = c.TournementId
                                         });
            var ret = await sqlTask;

            _logger.BeginScope("beginscope");

            _logger.LogCritical("critical");
            _logger.LogError("error");

            var sqlTask2 = Task.Run(() =>
                from c in _appContext.Contestent
                join t in _appContext.Tournement on c.TournementId equals t.Id
                select new ContestentsListViewModel()
                {
                    ContestentId = c.Id,
                    EnlistDate = c.EnlistDate,
                    UsersId = c.UsersId,
                    RegistrationEndDate = t.RegistrationEndDate,
                    RegistrationStartDate = t.RegistrationStartDate,
                    TournementEndDate = t.TournementEndDate,
                    TournementStartDate = t.TournementStartDate,
                    TournementName = t.Name,
                    TournementId = c.TournementId
                });


            var ret2 = await sqlTask2;
            return View(ret2);
        }

        // GET: Admin/Contestents/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
      
            var t = Task.Run(() =>
                {
                    return new ContestentsCreateEditModelView( id);
                });
            var model = await t;
            if (model == null) return NotFound();
            return View(model);
        }

        // GET: Admin/Contestents/Create
        public IActionResult Create()
        {
            var model = new ContestentsCreateEditModelView(_appContext,_idContext);
            return View(model);
        }

        // POST: Admin/Contestents/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,EnlistDate,TournementId,AspNetUsersId")] ContestentsCreateEditModelView contestentsCreateEditModelView)
        {
            if (ModelState.IsValid)
            {
                _appContext.Add(contestentsCreateEditModelView);
                await _appContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(contestentsCreateEditModelView);
        }

        // GET: Admin/Contestents/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //var cont = from ContestentsViewModel c in _context.ContestentsViewModel where (c.ContestentId == id) select new ContestentsViewModel() { AspNetUsersId = c.AspNetUsersId, ContestentId = c.ContestentId, EnlistDate = c.EnlistDate, RegistrationEndDate = c.RegistrationEndDate, RegistrationStartDate = c.RegistrationStartDate, TournementEndDate = c.TournementEndDate, TournementId = c.TournementId, TournementName = c.TournementName, TournementStartDate = c.TournementStartDate, UserName = c.UserName };
            //var cont2 = from ContestentsViewModel c in _context.ContestentsViewModel where (c.ContestentId == id) select c;
            var myTask = Task.Run(() => new ContestentsListViewModel(_appContext,_idContext, id));
            var contestentsViewModel = await myTask;
            //var contestentsViewModel = await _context.ContestentsViewModel.Where(c => c.ContestentId == id).FirstAsync<ContestentsViewModel>();

            if (contestentsViewModel == null)
            {
                return NotFound();
            }
            return View(contestentsViewModel);
        }

        // POST: Admin/Contestents/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ContestentId,UserName,EnlistDate,TournementName,RegistrationStartDate,RegistrationEndDate,TournementStartDate,TournementEndDate,TournementId,AspNetUsersId")] ContestentsListViewModel contestentsViewModel)
        {
            if (id != contestentsViewModel.ContestentId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _appContext.Update(contestentsViewModel);
                    await _appContext.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContestentsViewModelExists(contestentsViewModel.ContestentId))
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
            return View(contestentsViewModel);
        }

        // GET: Admin/Contestents/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var myTask = Task.Run(() => new ContestentsListViewModel(_appContext, _idContext, id));
            var contestentsViewModel = await myTask;
            //var contestentsViewModel = await _context.ContestentsViewModel
            //    .FirstOrDefaultAsync(m => m.ContestentId == id);
            if (contestentsViewModel == null)
            {
                return NotFound();
            }

            return View(contestentsViewModel);
        }

        // POST: Admin/Contestents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            //var contestentsViewModel = await _context.ContestentsViewModel.FindAsync(id);
            var contestent = await _appContext.Contestent.FindAsync(id);

            _appContext.Contestent.Remove(contestent);
            await _appContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ContestentsViewModelExists(int id)
        {
            ContestentsListViewModel contestentsViewModel = new ContestentsListViewModel(_appContext,_idContext, id);
            return (contestentsViewModel == null);
            //return _context.ContestentsViewModel.Any(e => e.ContestentId == id);
        }
        public async Task<IQueryable<ContestentsListViewModel>> GetContestentsViewModelQuery(int id)
        {
            var sqlTask = Task.Run(() => from u in _idContext.Users
                                         join c in _appContext.Contestent
                                         on u.Id.ToString() equals c.UsersId
                                         join t in _appContext.Tournement.AsNoTracking()
                                         on c.TournementId equals t.Id
                                         where (c.Id == id)
                                         select new ContestentsListViewModel
                                         {
                                             ContestentId = c.Id,
                                             EnlistDate = c.EnlistDate,
                                             UsersId = c.UsersId,
                                             RegistrationEndDate = t.RegistrationEndDate,
                                             RegistrationStartDate = t.RegistrationStartDate,
                                             TournementEndDate = t.TournementEndDate,
                                             TournementStartDate = t.TournementStartDate,
                                             TournementName = t.Name,
                                             TournementId = c.TournementId
                                         });
            var sqlTask2 = Task.Run(() => from u in _idContext.Users
                                          join c in _appContext.Contestent
                                          on u.Id.ToString() equals c.UsersId
                                          join t in _appContext.Tournement.AsNoTracking()
                                          on c.TournementId equals t.Id
                                          where (c.Id == id)
                                          select new ContestentsListViewModel
                                          {
                                              ContestentId = c.Id,
                                              EnlistDate = c.EnlistDate,
                                              UsersId = c.UsersId,
                                              RegistrationEndDate = t.RegistrationEndDate,
                                              RegistrationStartDate = t.RegistrationStartDate,
                                              TournementEndDate = t.TournementEndDate,
                                              TournementStartDate = t.TournementStartDate,
                                              TournementName = t.Name,
                                              TournementId = c.TournementId
                                          });

            return await sqlTask;
        }
    }
}
