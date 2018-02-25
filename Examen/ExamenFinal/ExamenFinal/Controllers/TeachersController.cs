using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ExamenFinal.Models;

namespace ExamenFinal.Controllers
{
    public class TeachersController : Controller
    {
        private readonly ExamenFinalContext _context;

        public TeachersController(ExamenFinalContext context)
        {
            _context = context;
        }

        // GET: Teachers
        public async Task<IActionResult> Index()
        {
            return View(await _context.MultChoice.ToListAsync());
        }

        // GET: Teachers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var multChoice = await _context.MultChoice
                .SingleOrDefaultAsync(m => m.Id == id);
            if (multChoice == null)
            {
                return NotFound();
            }

            return View(multChoice);
        }

        // GET: Teachers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Teachers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Question,AnswerA,HasTickA,AnswerB,HasTickB,AnswerC,HasTickC,AnswerD,HasTickD")] MultChoice multChoice)
        {
            if (ModelState.IsValid)
            {
                _context.Add(multChoice);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(multChoice);
        }

        // GET: Teachers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var multChoice = await _context.MultChoice.SingleOrDefaultAsync(m => m.Id == id);
            if (multChoice == null)
            {
                return NotFound();
            }
            return View(multChoice);
        }

        // POST: Teachers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Question,AnswerA,HasTickA,AnswerB,HasTickB,AnswerC,HasTickC,AnswerD,HasTickD")] MultChoice multChoice)
        {
            if (id != multChoice.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(multChoice);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MultChoiceExists(multChoice.Id))
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
            return View(multChoice);
        }

        // GET: Teachers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var multChoice = await _context.MultChoice
                .SingleOrDefaultAsync(m => m.Id == id);
            if (multChoice == null)
            {
                return NotFound();
            }

            return View(multChoice);
        }

        // POST: Teachers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var multChoice = await _context.MultChoice.SingleOrDefaultAsync(m => m.Id == id);
            _context.MultChoice.Remove(multChoice);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MultChoiceExists(int id)
        {
            return _context.MultChoice.Any(e => e.Id == id);
        }
    }
}
