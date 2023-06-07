using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _411000554_Final.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Music()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Music(string name, float? num)
        {
            var result = "";
            string[] music = {"do", "re", "mi", "fa", "so", "la", "xi"};
 
            ViewBag.Name = name;
            if (num > 7 || num < 1)
            {
                result = "錯誤";
            }
            else
            {
                int temp = Convert.ToInt32(num)-1;
                result = music[temp];
            }
            ViewBag.Result = result;

            return View();
        }
    }
}