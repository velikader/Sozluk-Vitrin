using DataAccessLayer.Abstracts;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
    public class EFHeadingDal : GenericRepo<Heading>, IHeadingDal
    {
    }
}
