using JuiceShopDAL;
using System.Collections.Generic;
using JuiceShopEntityLayer;
using System.Data.SqlClient;
using System.Data;

namespace JuiceShopBusinessLayer
{
    public class BussinessManager
    {
        public List<Juice> GetallJuiceFlavours()
        {
            Adoconnected dal = new Adoconnected();
            List<Juice> juiceLst = dal.GetallJuiceFlavours();
            return juiceLst;

        }
        public void PurchasedJuice(int Juiceid, int Quantity)
        {
            //TODO INSERT into database table 
            //1. create and configure connection object
            SqlConnection con = new SqlConnection();
            con.ConnectionString =@"Data Source=IN-5CG0255ZN3\SQLEXPRESS;Initial Catalog=JuiceShop_DB;Integrated Security=True";

            //2. Create and configure command for INSERT
            SqlCommand cmd = new SqlCommand("insert into JuicePurchased(juiceid,quantity) values(@juice_id,@qty)", con);
            cmd.CommandType = CommandType.Text;

            //3. pass values for the parameters
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@juice_id", Juiceid);
            cmd.Parameters.AddWithValue("@qty", Quantity);
            SqlCommand cmd1 = new SqlCommand("update JuicePurchased set JuicePurchased.amount=jp.quantity*j.price from JuicePurchased jp inner join juice j on jp.juiceid=j.juiceid",con);
            cmd1.CommandType = CommandType.Text;
            cmd1.Parameters.Clear();

            //4. open connect and execute the command
            con.Open();
            cmd.ExecuteNonQuery();
            cmd1.ExecuteNonQuery();

            //5. close connection
            con.Close();

        }
        public List<JuicePurchased> GetallJuicePurchased()
        {
            List<JuicePurchased> juiceslst = new List<JuicePurchased>();
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=IN-5CG0255ZN3\SQLEXPRESS;Initial Catalog=JuiceShop_DB;Integrated Security=True";
                SqlCommand cmd = new SqlCommand("select * from JuicePurchased", con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    JuicePurchased j = new JuicePurchased
                    {
                        purchase_no = (int)sdr[0],
                        juiceid = (int)sdr[1],
                        quantity = (int)sdr[2],
                        amount = (int)sdr[3]

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
