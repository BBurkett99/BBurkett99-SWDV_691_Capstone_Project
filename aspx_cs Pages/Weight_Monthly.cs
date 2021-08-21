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
    public partial class Weight_Monthly : System.Web.UI.Page

    {
        public static string WAvg;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            {
                //Current date
                DateTime dt = DateTime.Now;
                Console.WriteLine(dt.ToString("MMM"));
                var month = (dt.ToString("MMM"));
                string input = $"EXEC dbo.InsertMonthly_Weight_Average @Month, @Weight_Reading";
                string call = $"SELECT AVG (Weight_Reading) AS Weight_ReadingAvg FROM {month}_Weight_Readings";

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

                foreach (string Weight_ReadingAvg in str)
                {

                    WAvg = Weight_ReadingAvg;

                    SqlCommand insert = new SqlCommand(input, sqlcon);
                    insert.Parameters.AddWithValue("@Month", month);
                    insert.Parameters.AddWithValue("@Weight_Reading", WAvg);

                    dr.Close();
                    insert.ExecuteNonQuery();
                    sqlcon.Close();


                }

            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            {
                string getValue = WAvg;
            }

            int height = int.Parse(TextBox1.Text);

            {
                //Calculate Current BMI
                //int w = Int32.Parse(WAvg);
                var bmi = (220 * 703) / (height * height);
                Console.Write($"BMI = {bmi:.###}");
                //Current date
                DateTime dt = DateTime.Now;
                Console.WriteLine(dt.ToString("MMM"));
                var month = "Jul";//(dt.ToString("MMM"));
                string input = $"EXEC dbo.InsertMonthly_BMI_Average @Month, @BMI";

                SqlConnection sqlcon = new SqlConnection("Server=tcp:health-server.database.windows.net,1433;Initial Catalog=CapstoneData;Persist Security Info=False;User ID=BBurkett;Password=Merlin100%;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
                SqlCommand cmd = new SqlCommand();

                List<string> str = new List<string>();
                cmd.Connection = sqlcon;
                cmd.Connection.Open();

                //Input into database
                SqlCommand insert = new SqlCommand(input, sqlcon);
                    insert.Parameters.AddWithValue("@Month", month);
                    insert.Parameters.AddWithValue("@BMI", bmi);

                    //dr.Close();
                    insert.ExecuteNonQuery();
                    sqlcon.Close();

                }
            }

        }

    }

