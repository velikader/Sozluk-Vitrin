﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.Abstract
{
    public interface IAboutService
    {
        List<About> GetAboutList();
        void AboutAdd(About about);
        About GetById(int id);
        void AboutDelete(About about);
        void AboutUpdate(About about);
    }
}
