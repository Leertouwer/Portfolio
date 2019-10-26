using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Schaken.Controllers
{
    public class JeroenController : Controller
    {


        // GET: Jeroen
        public ActionResult Index()
        {
            return View();
        }

        // GET: Jeroen/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Jeroen/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Jeroen/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Jeroen/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Jeroen/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        public ActionResult actionName()
        {
            return View();
        }
        // GET: Jeroen/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Jeroen/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}