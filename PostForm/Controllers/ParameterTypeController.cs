using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PostForm.Models;

namespace PostForm.Controllers
{
    public class ParameterTypeController : Controller
    {
        // GET: ParameterType
        public ActionResult Index()
        {
            return View();
        }




        [HttpGet]
        public ActionResult FormCollectionQuestion()
        {
            return View();
        }

        //傳入Action方法的參數為FormCollection型別
        [HttpPost]
        public ActionResult FormCollectionQuestion(FormCollection fc)
        {
            return View("QuestionResult");
        }

        [HttpGet]
        public ActionResult RequestForm()
        {
            return View();
        }

        [HttpPost,ActionName("RequestForm")]
        public ActionResult RequestFormPost()
        {
            ViewData["Name"] = Request.Form["Name"];
            ViewData["Email"] = Request.Form["Email"];
            ViewData["Mobile"] = Request.Form["Mobile"];
            ViewData["Comments"] = Request.Form["Comments"];

            return View("RequestFormPost");
        }


        //用QueryString來接收
        [HttpGet]
        public ActionResult FormQueryString()
        {
            
            if (Request.QueryString.Count > 0)
            {
                ViewData["Name"] = Request.QueryString["Name"];
                ViewData["Email"] = Request.QueryString["Email"];
                ViewData["Mobile"] = Request.QueryString["Mobile"];
                ViewData["Comments"] = Request.QueryString["Comments"];

                Question question = new Question
                {
                    Name = Request.QueryString["Name"],
                    Email = Request.QueryString["Email"],
                    Mobile = Request.QueryString["Mobile"],
                    Comments = Request.QueryString["Comments"]
                };

                return View("QuestionResult", question);
            }

            return View();
        }

        
        [HttpGet]
        public ActionResult FormClass()
        {
            return View();
        }

        //傳入Action方法的參數為class型別(用class來接收)
        [HttpPost]
        public ActionResult FormClass(Question question)
        {
            return View();
        }
    }
}