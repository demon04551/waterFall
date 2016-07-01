using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WaterFall.Model;

namespace WaterFall.BLL
{
    public class GetImage
    {
        WaterFall.DAL.GetImage dal = new DAL.GetImage();
        public List<IndexImage> ImgList(int pageIndex, int pageSize, out int pageCount, out int recordCount)
        {
            return dal.ImgList(pageIndex, pageSize, out pageCount, out recordCount);
        }
    }
}
