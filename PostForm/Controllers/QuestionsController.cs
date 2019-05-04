using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PostForm.Models;

namespace PostForm.Controllers
{
    public class QuestionsController : Controller
    {
        private PostFormContext db = new PostFormContext();

        // GET: Questions
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListAllQuestions()
        {
            return View(db.Questions.ToList());
        }


        //HtmlFormQuestion --> HtmlFormQuestion (Form以Html設計)
        [HttpGet]
        public ActionResult HtmlFormQuestion()
        {
            return View();
        }

        [HttpPost]
        public ActionResult HtmlFormQuestion(string name, string email, string mobile, string comments)
        {
            ViewData["Name"] = name;
            ViewData["Email"] = email;
            ViewData["Mobile"] = mobile;
            ViewData["Comments"] = comments;

            Question q = new Question
            {
                Name = name,
                Email = email,
                Mobile = mobile,
                Comments = comments
            };

            db.Questions.Add(q);
            db.SaveChanges();

            return View("QuestionResult");
        }



        //HtmlPages/AskQuestion.html -->HandleQuestion (Form以Html設計)
        [HttpPost]
        //[ActionName("Question")]
        public ActionResult HandleQuestion(string name, string email, string mobile, string comments)
        {
            ViewData["Name"] = name;
            ViewData["Email"] = email;
            ViewData["Mobile"] = mobile;
            ViewData["Comments"] = comments;

            return View("QuestionResult");
        }

        //MvcFormQuestion --> MvcFormQuestion (Form以HtmlHelper設計)
        [HttpGet]
        public ActionResult MvcFormQuestion()
        {
            return View();
        }

        [HttpPost]
        public ActionResult MvcFormQuestion(string name, string email, string mobile, string comments)
        {
            ViewData["Name"] = name;
            ViewData["Email"] = email;
            ViewData["Mobile"] = mobile;
            ViewData["Comments"] = comments;

            return View("QuestionResult");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}