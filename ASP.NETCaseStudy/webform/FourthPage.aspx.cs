using DALLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entitylayer;

namespace webform
{
    public partial class FourthPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(Page.IsValid==true)
            {
                Adoconnected dal = new Adoconnected();
                message mssg = new message()
                { 
                    subject=txtsub.Text,
                    Message=txtMsg.Text,
                    parentname=txtParentName.Text
                             
                };
                dal.AddPostMessages(mssg);
                DispalyMsg.Text = "Posted Successfully";
            }
        }
    }
}