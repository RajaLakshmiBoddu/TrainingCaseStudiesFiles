using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.ComponentModel;
using Entitylayer;
using System.Net.Configuration;
using System.Runtime.Remoting.Messaging;

namespace DALLayer
{
    public class Adoconnected
    {
        SqlConnection con;

        public Adoconnected()
        {
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=IN-5CG0255ZN3\SQLEXPRESS;Initial Catalog=DXCDB;Integrated Security=True";

        }
        public void AddUserName(ParentPrjs pdetails)
        {
            SqlCommand cmd = new SqlCommand("insert into tbl_Parent values(@parentname,@pwd)", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@parentname", pdetails.parentname);
            cmd.Parameters.AddWithValue("@pwd", pdetails.password);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();


        }
        public int checklogin(ParentPrjs ck)
        {

            SqlCommand cmd = new SqlCommand("select * from tbl_Parent where ParentName=@username and Password=@password", con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@username", ck.parentname);
            cmd.Parameters.AddWithValue("@password", ck.password);
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            ParentPrjs prt = null;
            int count = 0;
            if (sdr.Read())
            {

                prt = new ParentPrjs
                {
                    parentname = sdr[0].ToString(),
                    password = sdr[1].ToString(),

                };
                count++;
            }
            con.Close();
            return count;
        }
        public void AddPostMessages(message mssg)
        {
            SqlCommand cmd = new SqlCommand("insert into tbl_messages(ParentName,subject,message) values(@username,@sub,@msg)", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@username", mssg.parentname);
            cmd.Parameters.AddWithValue("@sub", mssg.subject);
            cmd.Parameters.AddWithValue("@msg", mssg.Message);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }
        public List<message> GetMsgBySub(string subject)
        {
            List<message> lstmsgs = new List<message>();
            SqlCommand cmd = new SqlCommand("select * from tbl_messages where subject=@sub", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@sub", subject);
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            message msg = null;
            while (sdr.Read())
            {
                msg = new message
                {
                    id=(int)sdr[0],
                    parentname = sdr[1].ToString(),
                    subject = sdr[2].ToString(),
                    Message = sdr[3].ToString(),

                };
                lstmsgs.Add(msg);
            }
            con.Close();
            return lstmsgs;
        }
        public List<message> GetAllMessages()
        {
            List<message> lstmsgs = new List<message>();
            SqlCommand cmd = new SqlCommand("select subject from tbl_messages", con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            message msg = null;
            while (sdr.Read())
            {
                msg = new message
                {
                    subject = sdr[0].ToString(),
                };
                lstmsgs.Add(msg);
            }
            con.Close();
            return lstmsgs;
        }
    }
}
