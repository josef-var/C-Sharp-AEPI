using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControllerCinco.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ControllerCinco.Controllers
{
    public class CincoController : Controller
    {

        // GET: Cinco/Suma/5
        public ActionResult Suma(int id)
        {
            ViewBag.MyResult = id + 5;
            return View();
        }
        // GET: Cinco
        public ActionResult Index()
        {
            return View();
        }

        // GET: Cinco/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Cinco/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cinco/Create
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

        // GET: Cinco/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Cinco/Edit/5
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

        // GET: Cinco/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Cinco/Delete/5
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