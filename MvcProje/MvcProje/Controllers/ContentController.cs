﻿using BuisnessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProje.Controllers
{
    public class ContentController : Controller
    {
        ContentManager cm = new ContentManager(new EFContentDal());
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetAllContent(string p)
        {
            var values = cm.GetContentList(p);
            return View(values);
        }
        public ActionResult ContentByHeading(int id)
        {
            var contentValues = cm.GetListByHeadingId(id);
            return View(contentValues);
        }

    }
}