using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using WaterFall.Model;

namespace WaterFall.DAL
{
    public class GetImage
    {
        public List<IndexImage> ImgList(int pageIndex, int pageSize, out int pageCount, out int recordCount)
        {
            string sql = "usp_Img";
            List<IndexImage> list = new List<IndexImage>();
            SqlParameter[] pms = new SqlParameter[]{
                new SqlParameter("@pageIndex",SqlDbType.Int){Value=pageIndex},
                new SqlParameter("@pageSize",SqlDbType.Int){Value=pageSize},
                new SqlParameter("@pageCount",SqlDbType.Int){Direction=ParameterDirection.Output},
                new SqlParameter("@recordCount",SqlDbType.Int){Direction=ParameterDirection.Output}
            };
            using (SqlDataReader reader=SqlHelper.ExecuteReader(sql,CommandType.StoredProcedure,pms))
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        IndexImage img = new IndexImage();
                        img.ImgId = reader.GetInt32(0);
                        img.ImgUrl = reader.GetString(1);
                        list.Add(img);
                    }
                }
            }
            pageCount = Convert.ToInt32(pms[2].Value);
            recordCount = Convert.ToInt32(pms[3].Value);
            return list;

        }
    }
}
