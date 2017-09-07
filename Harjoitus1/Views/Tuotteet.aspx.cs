using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Tikanpoika.Views
{
    public partial class Views_Tuotteet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Int32 tuoteId = (Int32)GridView1.SelectedValue;
            this.Session["tuoteid"] = tuoteId;
            Response.Redirect("Tuote.aspx");
        }
    }
}