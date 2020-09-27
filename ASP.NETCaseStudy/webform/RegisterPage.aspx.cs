using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using DALLayer;
using System.ComponentModel;
using Entitylayer;


namespace webform
{
    public partial class RegisterPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Page.IsValid == true)
            {
                Adoconnected dal = new Adoconnected();
                ParentPrjs pdetalis = new ParentPrjs()
                {
                    parentname = txtUsername.Text,
                    password = txtPwd.Text

                };
                dal.AddUserName(pdetalis);
            }
            lblMsg.Text = "Registered Successfully";
        }
    }
}