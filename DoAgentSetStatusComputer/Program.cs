using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BUS;
using System.Net;
using System.Threading;
using DAO.DataProvider;
using EXONSYSTEM.Common;
using System.Data.SqlClient;

namespace DoAgentSetStatusComputer
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SqlConnection Sql = new SqlConnection();
                string connectString = DAO.Common.GetConnectString("EXON_SYSTEM_TESTEntities");
                Sql.ConnectionString = connectString;
                Sql.Open();

                while (true)
                    {
                        StatusComputerBUS.Instance.SetStatusComputer(Dns.GetHostName(),Sql);
                        Thread.Sleep(5000);
                    }
 

                
            }
            catch
            {

            }
          

        }
    }
}
