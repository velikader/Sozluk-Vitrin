using DataAccessLayer.Abstracts;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
    public class EFWriterDal : GenericRepo<Writer>, IWriterDal
    {
    }
}
