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
    public partial class ThirdPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Adoconnected dal = new Adoconnected();
            List<message> Subjects = dal.GetAllMessages();
            DropDownList1.DataSource = Subjects;
            DropDownList1.DataTextField = "subject";
            DropDownList1.DataBind();

        }

        protected void btnDisplay_Click(object sender, EventArgs e)
        {

           
            Response.Redirect("FifthPage.aspx?subject="+DropDownList1.Text);
        }
    }
}