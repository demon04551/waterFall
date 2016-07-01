using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WaterFall.Model;

namespace 离散数学动态加载数据.Controllers
{
    public class DemoController : Controller
    {
        //
        // GET: /Demo/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SendImage()
        {
            //从数据库获取图片 返回JSON格式的数据
            int pageIndex, pageSize, pageCount, recordCount;
            pageIndex = String.IsNullOrEmpty(Request["pageIndex"]) ? 1 : int.Parse(Request["pageIndex"]);
            pageSize = String.IsNullOrEmpty(Request["pageSize"]) ? 4 : int.Parse(Request["pageSize"]);
          WaterFall.BLL.GetImage bll = new WaterFall.BLL.GetImage();
          List<IndexImage> rec= bll.ImgList(pageIndex, pageSize, out pageCount, out recordCount);
            var sendData =new { image=rec};
            return Json(sendData, JsonRequestBehavior.AllowGet);
        }

    }
}
