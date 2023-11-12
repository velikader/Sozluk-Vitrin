﻿using DataAccessLayer.Abstracts;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
    public class EFContentDal : GenericRepo<Content>, IContentDal
    {
    }
}
