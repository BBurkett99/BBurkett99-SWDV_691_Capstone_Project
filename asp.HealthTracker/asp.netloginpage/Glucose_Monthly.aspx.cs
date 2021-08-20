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

    public partial class Glucose_Monthly : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }


        public void Button1_Click(object sender, EventArgs e)
        {

            {

                DateTime dt = DateTime.Now;
                Console.WriteLine(dt.ToString("MMM"));
                var month = (dt.ToString("MMM"));
                string input = $"EXEC dbo.InsertMonthly_Glucose_Average @Month, @Glucose_Reading";
                string call = $"SELECT AVG (Glucose_Reading) AS Glucose_ReadingAvg FROM {month}_Glucose_Readings";

                SqlConnection sqlcon = new SqlConnection("Server=tcp:health-server.database.windows.net,1433;Initial Catalog=CapstoneData;Persist Security Info=False;User ID=BBurkett;Password=Merlin100%;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
                SqlCommand cmd = new SqlCommand();

                List<string> str = new List<string>();
                cmd.Connection = sqlcon;
                cmd.Connection.Open();
                cmd.CommandText = (call);
                
                SqlDataReader dr = cmd.ExecuteReader();
                
                while (dr.Read())
                {
                    str.Add(dr.GetValue(0).ToString());
                }

                foreach (string Glucose_ReadingAvg in str)
                {
                    string Avg = Glucose_ReadingAvg;
                    
                    Session["ReadingAvg"] = Avg;
                    
                    SqlCommand insert = new SqlCommand(input,  sqlcon);
                    insert.Parameters.AddWithValue("@Month", month);
                    insert.Parameters.AddWithValue("@Glucose_Reading", Avg);

                    dr.Close();
                    insert.ExecuteNonQuery();
                    sqlcon.Close();
               
 
                }




            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }

        protected void Chart1_Load(object sender, EventArgs e)
       {

        }
    }
    }

    
    