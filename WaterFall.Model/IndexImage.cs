using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WaterFall.Model
{
    public class IndexImage
    {
        private int _imgId;
        public int ImgId
        {
            get { return _imgId; }
            set { _imgId = value; }
        }
        private string _imgUrl;
        public string ImgUrl
        {
            get { return _imgUrl; }
            set { _imgUrl = value; }
        }
    }
}
