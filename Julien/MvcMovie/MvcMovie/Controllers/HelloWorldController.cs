using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/ 

        /*
        public string Index()
        {
            return "This is my <b>default</b> action...";
        }
        */
        public ActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 
        /*
        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
        */

        public ActionResult Welcome(string name, int numTimes = 1)
        {
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = numTimes;

            return View();
        }

        // 
        // GET: /HelloWorld/YouYou/?name=xxx

        private static int _numTimes = 0;
        public string YouYou(string name)
        {
            return HttpUtility.HtmlEncode("Hello " + name + ", pour la " + (++_numTimes) + (_numTimes>1 ? "ième " : "ère ") + "fois");
        }

        //
        // Get: /HelloWorld/Halo/5?name=xxx
        public string Halo(string name, int id = 1)
        {
            return HttpUtility.HtmlEncode("Hello " + name + ", ID: " + id);
        }


    }
}
