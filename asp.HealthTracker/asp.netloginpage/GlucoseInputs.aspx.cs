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
    public partial class GlucoseInputs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == true)
            {
                Label1.Text = ("Data was received.");
                /*Thread.Sleep(3000);*/
                

            }

            
        }




        protected void Button1_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            Console.WriteLine(dt.ToString("MMM"));

            var title = (dt.ToString("MMM"));
            //Console.WriteLine(test);

            //string value = selectedMonth.Value;
            //Response.Write(title);
            //string title = "July";
            string Query = $"EXEC dbo.Insert{title}_Glucose_Readings @Glucose_Reading";
           
           SqlConnection sqlcon = new SqlConnection("Server=tcp:health-server.database.windows.net,1433;Initial Catalog=CapstoneData;Persist Security Info=False;User ID=BBurkett;Password=Merlin100%;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            {
                SqlCommand insert = new SqlCommand(Query, sqlcon);
                insert.Parameters.AddWithValue("@Glucose_Reading", TextBox1.Text);

                sqlcon.Open();
                insert.ExecuteNonQuery();
                sqlcon.Close();

                if (IsPostBack)
                {
                    TextBox1.Text = "";
                }

            }
        }
    }
}