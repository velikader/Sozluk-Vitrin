using BuisnessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProje.Controllers
{
    public class AuthorizationController : Controller
    {
        AdminManager admn = new AdminManager(new EFAdminDal());
        public ActionResult Index()
        {
            var adminvalues = admn.GetAdminList();
            return View(adminvalues);
        }
        
        [HttpGet]
        public ActionResult AddAdmin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddAdmin(Admin p)
        {
            admn.AdminAdd(p);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult EditAdminRole(int id)
        {
            var adminvalue = admn.GetById(id);

            return View(adminvalue);

        }
        [HttpPost]
        public ActionResult EditAdminRole(Admin p)
        {
            admn.AdminUpdate(p);
            return RedirectToAction("Index");

        }
    }
}