using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DALLayer;
using Entitylayer;

namespace webform
{
    public partial class FifthPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string subject = Request.QueryString.Get("subject");
            Adoconnected dal = new Adoconnected();
            List<message> lstmsgs = dal.GetMsgBySub(subject);
            GridView1.DataSource = lstmsgs;
            GridView1.DataBind();
            //lblMsg.Text = Session["name"].ToString();
        }
    }
}