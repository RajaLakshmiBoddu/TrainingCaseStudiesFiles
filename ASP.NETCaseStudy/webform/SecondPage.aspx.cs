using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DALLayer;
using System.ComponentModel;
using Entitylayer;


namespace webform
{
    public partial class SecondPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ParentPrjs prt = new ParentPrjs
            { 
                parentname=txtName.Text,
                password=txtPwd.Text
            
            
            };
            Adoconnected dal = new Adoconnected();
            int count = dal.checklogin(prt);
            if(count>0)
            {
                Response.Redirect("FourthPage.aspx");
            }
            else
            {
                labelMsg.Text = "Invalid Username/Password";
            }

        }

    }
}