using MvcProje.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProje.Controllers
{
    public class ChartController : Controller
    {
        // GET: Chart
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CategoryChart() 
        {
            return Json(BlogList(), JsonRequestBehavior.AllowGet);
        }



        public List<CategoryClass> BlogList()
        {
            List<CategoryClass> ct = new List<CategoryClass>
            {
                new CategoryClass()
                {
                    CategoryName = "Yazılım",
                    CategoryCount = 8,

                },
                new CategoryClass()
                {
                    CategoryName = "Seyehat",
                    CategoryCount = 4,
                },
                new CategoryClass()
                {
                    CategoryName = "Spor",
                    CategoryCount = 1,
                }
            };
            return ct;

        }
    }
}