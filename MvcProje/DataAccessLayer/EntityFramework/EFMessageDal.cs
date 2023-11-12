using DataAccessLayer.Abstracts;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
    public class EFMessageDal : GenericRepo<Message>, IMessageDal
    {
    }
}
