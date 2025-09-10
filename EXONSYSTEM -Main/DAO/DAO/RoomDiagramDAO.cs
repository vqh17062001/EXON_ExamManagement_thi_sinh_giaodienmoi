using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO.DataProvider;
namespace DAO.DAO
{
    public  class RoomDiagramDAO
    {
        private static RoomDiagramDAO instance;
        public static RoomDiagramDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new RoomDiagramDAO();
                }
                return instance;
            }
        }
        private RoomDiagramDAO() { }
        
        public bool UpdateDiagrams(int RoomTestID,RoomDiagrams RoomDiagrams, SqlConnection sql)
        {
            using (EXON_SYSTEM_TESTEntities db = new EXON_SYSTEM_TESTEntities())
            {
                try

                {
                   
                    ROOMDIAGRAM rd = db.ROOMDIAGRAMS.Where(x=>x.ComputerName==RoomDiagrams.ComputerName && x.RoomTestID==RoomTestID).SingleOrDefault();
                    if (rd == null)
                    {
                        /*rd.ComputerCode = RoomDiagrams.ComputerCode;
                        rd.ComputerName = RoomDiagrams.ComputerName;
                        rd.Status = RoomDiagrams.Status;
                        rd.RoomTestID = RoomTestID;
                        db.ROOMDIAGRAMS.Add(rd);
                        db.SaveChanges();*/
                        // DA SUA
                        SqlCommand sqlcmd = new SqlCommand("INSERT INTO ROOMDIAGRAMS(ComputerName,ComputerCode,RoomTestID,Status) values (@ComputerName,@ComputerCode,@RoomTestID,@Status) ;", sql);

                        sqlcmd.Parameters.Add("@ComputerName", RoomDiagrams.ComputerName ?? (object)DBNull.Value);
                        sqlcmd.Parameters.Add("@ComputerCode", RoomDiagrams.ComputerCode ?? (object)DBNull.Value);
                        sqlcmd.Parameters.Add("@RoomTestID", RoomTestID);
                        sqlcmd.Parameters.Add("@Status", RoomDiagrams.Status);
                        int row = 0;
                        while (row == 0)
                        {
                            row = sqlcmd.ExecuteNonQuery();

                        }
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch
                {
                    return false;
                }
            }
        }
    }
}
