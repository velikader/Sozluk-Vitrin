﻿using BuisnessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProje.Controllers
{
    public class WriterPanelContentController : Controller
    {
        ContentManager cm = new ContentManager(new EFContentDal());
        Context c = new Context();
        public ActionResult MyContent(string p)
        {
            p = (string)Session["WriterMail"];
            var WriterIdInfo=c.Writers.Where(x=>x.WriterMail == p).Select(y=>y.WriterId).FirstOrDefault();
            //ViewBag.d = p;
            var contentValues = cm.GetListByWriter(WriterIdInfo);
            return View(contentValues);
        }
        [HttpGet]
        public ActionResult AddContent(int id)
        {
            ViewBag.d = id;
            return View();
        }
        [HttpPost]
        public ActionResult AddContent(Content p)
        {
            string mail = (string)Session["WriterMail"];
            var WriterIdInfo = c.Writers.Where(x => x.WriterMail == mail).Select(y => y.WriterId).FirstOrDefault();

            p.ContentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.WriterId = WriterIdInfo;
            p.ContentStatus = true;
            cm.ContentAdd(p);   
            return RedirectToAction("MyContent");
        }
        public ActionResult ToDoList() 
        {
            return View();
        }
    }
}