using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ExamenFinal.Models;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;

namespace ExamenFinal.Controllers
{
    public class StudentsController : Controller
    {
        private readonly ExamenFinalContext _context;

        public StudentsController(ExamenFinalContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Answers()
        {
            return View(await _context.MultChoice.ToListAsync());
        }
        // GET: Students
        public async Task<IActionResult> Index()
        {
            return View(await _context.MultChoice.ToListAsync());
        }

        //[HttpPost]
        //public ActionResult QuizTest(List<MultChoice> resultQuiz)
        //{
        //    List<MultChoice> finalResultQuiz = new List<MultChoice>();

        //    foreach (MultChoice answser in resultQuiz)
        //    {
        //        MultChoice result = _context.MultChoice.Any(a => a.Id == id).Select(a => new MultChoice
        //        {
        //            QuestionID = a.QuestionID.Value,
        //            AnswerQ = a.AnswerText,
        //            isCorrect = (answser.AnswerQ.ToLower().Equals(a.AnswerText.ToLower()))

        //        }).FirstOrDefault();

        //        finalResultQuiz.Add(result);
        //    }

        //    return Json(new { result = finalResultQuiz });
        //}


        private bool MultChoiceExists(int id)
        {
            return _context.MultChoice.Any(e => e.Id == id);
        }
    }
}
