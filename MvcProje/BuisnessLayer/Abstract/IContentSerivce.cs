using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.Abstract
{
    public interface IContentSerivce
    {
        List<Content> GetContentList(string p);
        List<Content> GetListByHeadingId(int id);
        List<Content> GetListByWriter(int id);

        void ContentAdd(Content content);
        Content GetById(int id);
        void ContentDelete(Content content);
        void ContentUpdate(Content content);
    }
}
