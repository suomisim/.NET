using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace Tikanpoika.Views
{

    public partial class Views_Tuote : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Int32 tuoteId = (Int32)this.Session["tuoteid"];
            String conStr = WebConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            String queryStr = "select TuoteID, Nimi, Hinta, Veroprosentti from Tuote where TuoteID = @tuoteID;";
            SqlConnection con = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand(queryStr, con);

            cmd.Parameters.AddWithValue("@tuoteID", tuoteId);

            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                FormView1.DataSource = reader;
                FormView1.DataBind();
                reader.Close();

            } catch (SqlException ex)
            {
                throw new ApplicationException("ERROR ERROR!");
            } finally
            {
                con.Close();
            }

        }
    }

}