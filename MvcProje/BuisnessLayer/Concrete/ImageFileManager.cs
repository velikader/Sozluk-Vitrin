using BuisnessLayer.Abstract;
using DataAccessLayer.Abstracts;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.Concrete
{
    public class ImageFileManager :IImageFileService
    {
        IImageFileDal _ımagefiledal;

        public ImageFileManager(IImageFileDal ımagefiledal)
        {
            _ımagefiledal = ımagefiledal;
        }

        public List<ImagesFile> GetImageFileList()
        {
            return _ımagefiledal.List();
        }
    }
}
