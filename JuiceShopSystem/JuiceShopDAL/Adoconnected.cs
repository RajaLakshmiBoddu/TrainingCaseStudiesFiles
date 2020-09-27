using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using JuiceShopEntityLayer;
namespace JuiceShopDAL
{
    public class Adoconnected
    {
        public List<Juice> GetallJuiceFlavours()
        {
            List<Juice> juiceslst = new List<Juice>();
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=IN-5CG0255ZN3\SQLEXPRESS;Initial Catalog=JuiceShop_DB;Integrated Security=True";
                SqlCommand cmd = new SqlCommand("select * from juice", con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    Juice j = new Juice
                    {
                        juiceid = (int)sdr[0],
                        juice_flavour = sdr[1].ToString(),
                        price = (int)sdr[2]

                    };
                    juiceslst.Add(j);

                }
                sdr.Close();
                con.Close();

                return juiceslst;
            }
        }
    }
}
