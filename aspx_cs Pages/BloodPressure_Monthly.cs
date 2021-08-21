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
    public partial class BloodPressure_Monthly : System.Web.UI.Page

    {

        public static string SAvg;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Current date
            DateTime dt = DateTime.Now;
            Console.WriteLine(dt.ToString("MMM"));
            var month = (dt.ToString("MMM"));
            string input = $"EXEC dbo.InsertMonthly_BP_Average @Month, @systolic_Reading, @diastolic_Reading";
            string call = $"SELECT AVG (BP_Readings_Syst) AS systolic_ReadingAvg FROM {month}_BP_Readings";

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
            
            foreach (string systolic_ReadingAvg in str)

            {
                
                SAvg = systolic_ReadingAvg; ;
                
                //MessageBox.Show(SAvg);

                SqlCommand insert = new SqlCommand(input, sqlcon);

                dr.Close();
                //insert.ExecuteNonQuery();
                sqlcon.Close();

                {

                }

            }

        }

        protected void SqlDataSource2_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            {
                string getValue = BloodPressure_Monthly.SAvg;
            }
            //Current date
            DateTime dt = DateTime.Now;
            Console.WriteLine(dt.ToString("MMM"));
            var month = (dt.ToString("MMM"));
            string input = $"EXEC dbo.InsertMonthly_BP_Average @Month, @systolic_Reading, @diastolic_Reading";
            string call2 = $"SELECT AVG (BP_Readings_Dia) AS diastolic_ReadingAvg FROM {month}_BP_Readings";

            SqlConnection sqlcon = new SqlConnection("Server=tcp:health-server.database.windows.net,1433;Initial Catalog=CapstoneData;Persist Security Info=False;User ID=BBurkett;Password=Merlin100%;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            SqlCommand cmd = new SqlCommand();

            List<string> str = new List<string>();
            cmd.Connection = sqlcon;
            cmd.Connection.Open();
            cmd.CommandText = (call2);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                str.Add(dr.GetValue(0).ToString());

            }

            foreach (string diastolic_ReadingAvg in str)

            {

                string DAvg = diastolic_ReadingAvg;

                //MessageBox.Show(DAvg);

                {
                    //Input into database
                    SqlCommand insert = new SqlCommand(input, sqlcon);
                    insert.Parameters.AddWithValue("@Month", month);
                    insert.Parameters.AddWithValue("@systolic_Reading", SAvg);
                    insert.Parameters.AddWithValue("@diastolic_Reading", DAvg);

                    dr.Close();
                    insert.ExecuteNonQuery();
                    sqlcon.Close();

                }

            }

        }

    }
}
