using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PostForm.Controllers
{
    public class QuestionsController : Controller
    {
        // GET: Questions
        public ActionResult Index()
        {
            return View();
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
        [ValidateAntiForgeryToken]
        public ActionResult MvcFormQuestion(string name, string email, string mobile, string comments)
        {
            ViewData["Name"] = name;
            ViewData["Email"] = email;
            ViewData["Mobile"] = mobile;
            ViewData["Comments"] = comments;

            return View("QuestionResult");
        }
    }
}