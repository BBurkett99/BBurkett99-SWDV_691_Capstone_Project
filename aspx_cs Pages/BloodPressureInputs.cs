using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Text;
using System.Web.Security;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Windows.Forms;
using System.Threading;

namespace asp.netloginpage
{
    public partial class BloodPressureInputs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == true)
            {
                Label1.Text = ("Data was received.");
                Label2.Text = ("Data was received.");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Current Date
            DateTime dt = DateTime.Now;
            Console.WriteLine(dt.ToString("MMM"));
            var title = (dt.ToString("MMM"));
            string Query = $"EXEC dbo.Insert{title}_BP_Readings @BP_Readings_Syst, @BP_Readings_Dia";

            SqlConnection sqlcon = new SqlConnection("Server=tcp:health-server.database.windows.net,1433;Initial Catalog=CapstoneData;Persist Security Info=False;User ID=BBurkett;Password=Merlin100%;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            {
                //Input into database
                SqlCommand insert = new SqlCommand(Query, sqlcon);
                insert.Parameters.AddWithValue("@BP_Readings_Syst", systolic_input.Text);
                insert.Parameters.AddWithValue("@BP_Readings_Dia", diastolic_input.Text);

                sqlcon.Open();
                insert.ExecuteNonQuery();
                sqlcon.Close();

                if (IsPostBack)
                {
                    systolic_input.Text = "";
                    diastolic_input.Text = "";
                }

            }
        }
    }
}