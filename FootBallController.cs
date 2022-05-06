using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication7.Controllers
{
    public class FootBallController : Controller
    {
        // GET: FootBall
        public ActionResult Index()
        {
            return View();
        }
        public void Save(string teamname1, string teamname2, string status, string winteam, int points)
        {
            SqlConnection con = new SqlConnection("data source =ZED_AIR_CX3\\SQLEXPRESS01; database = samples; integrated security=SSPI");
            SqlCommand cmd = con.CreateCommand();
            con.Open();
            cmd.CommandText = "Execute spFootball @TeamName1,@TeamName2,@Status,@WinningTeam,@Points";
            cmd.Parameters.Add("@TeamName1", SqlDbType.VarChar, 50).Value = teamname1;
            cmd.Parameters.Add("@TeamName2", SqlDbType.VarChar, 50).Value = teamname2;
            cmd.Parameters.Add("@Status", SqlDbType.VarChar, 50).Value = status;
            cmd.Parameters.Add("@WinningTeam", SqlDbType.VarChar, 50).Value = winteam;
            cmd.Parameters.Add("@Points", SqlDbType.Int, 4).Value = points;
            //adding paramerters to  SqlCommand below

            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
    }
}