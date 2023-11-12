﻿using DataAccessLayer.Abstracts;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EFCategoryDal : GenericRepo<Category>, ICategoryDal
    {
    }
}
