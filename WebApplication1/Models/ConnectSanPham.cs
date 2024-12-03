using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Web;
using System.Configuration;

namespace WebApplication1.Models
{
    public class ConnectSanPham
    {
        public string constr = ConfigurationManager.ConnectionStrings["Connect1"].ConnectionString;
        public List<SanPham> getData()
        {
            List<SanPham> lsSP = new List<SanPham>();
            SqlConnection con = new SqlConnection(constr);
            string sql = "select * from SanPham";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                SanPham sp = new SanPham();
                sp.MaSP = Convert.ToInt32(rdr.GetValue(0).ToString());
                sp.TenSP = rdr.GetValue(1).ToString();
                sp.DuongDan = rdr.GetValue(2).ToString();
                sp.Gia = float.Parse(rdr.GetValue(3).ToString());
                sp.MoTa = rdr.GetValue(4).ToString();
                sp.MaLoai = Convert.ToInt32(rdr.GetValue(5).ToString());
                lsSP.Add(sp);
            }
            return lsSP;
        }
    }
}