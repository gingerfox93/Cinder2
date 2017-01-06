using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Cinder
{
    static class Monitoring
    {

        public static Dictionary<string, object> getCaptureProcStats(string ObjectName, string DatabaseName, string ServerName)
        {
            Dictionary<string, object> Results = new Dictionary<string, object>();
            Dictionary<string, string> Data = new Dictionary<string, string>();
            List<string> Errors = new List<string>();

            string MonitoringDatabase = "LS_Training";

            SqlConnection myConnection = new SqlConnection(
                "Server="+ Cinder.Properties.Settings.Default.MonitoringServer + 
                ";Database="+ MonitoringDatabase + 
                ";Integrated Security=SSPI" +
                ";Connection Timeout=5;"
            );
            
            try
            {
                myConnection.Open();

                try
                {
                    SqlDataReader myReader = null;
                    SqlCommand myCommand = new SqlCommand(
                        @"
                        select TOP 1 ID as execPS,DATECREATED as lastCached ,NAME as execPM ,432 as execPH,  FLOOR(RAND(CHECKSUM(NEWID()))*(9999-1000)+1000) as execPD
                        from [dbo].[SlidingWindowDaily_PTN] WITH(NOLOCK)"
                        , myConnection);
                    myReader = myCommand.ExecuteReader();

                    while (myReader.Read())
                    {
                        Data.Add("execPS", myReader["execPS"].ToString());
                        Data.Add("execPM", myReader["execPM"].ToString());
                        Data.Add("execPH", myReader["execPH"].ToString());
                        Data.Add("execPD", myReader["execPD"].ToString());
                        Data.Add("lastCached", myReader["lastCached"].ToString());
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }

            }
            catch (Exception e)
            {
                Errors.Add("Failed to connect to " + Cinder.Properties.Settings.Default.MonitoringServer + "." + MonitoringDatabase);
            }



            Results.Add("Data", Data);
            Results.Add("Errors",Errors);

            return Results;
        }



    }
}
