using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;

namespace FootBallLeauge
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            string CS = @"data source =ZED_AIR_CX3\SQLEXPRESS0 ;database = samples;integrated security = SSPI";
            SqlConnection con = new SqlConnection(CS);
            SqlCommand cmd = new SqlCommand("select WinningTeam from footBallLeague where Status = 'Win'", con);
            List<FootBallLeague> listfootBallLeague = new List<footballleauge>();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader(); // Executing the SQL query  
            while (sdr.Read())
            {
                FootBallLeauge ft = new FootBallLeauge();

                ft.WinningTeam = sdr["WinningTeam"].ToString();
                

                listfootBallLeague.Add(ft);
            }
            GridView1.DataSource = listfootBallLeague;
            GridView1.DataBind();

        }
    }
    
    
}