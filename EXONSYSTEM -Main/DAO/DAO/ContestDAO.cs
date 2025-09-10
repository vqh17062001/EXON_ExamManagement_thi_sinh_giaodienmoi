using DAO.DataProvider;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.SqlClient;

namespace DAO.DAO
{
    public class ContestDAO
    {
        private static ContestDAO instance;
        public static ContestDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ContestDAO();
                }
                return instance;
            }
        }
        private ContestDAO() { }

        public void GetContestByShiftTime(string ComputerName, out Contest ContestOut, out ErrorController EC)
        {
            Contest C = new Contest();
            using (EXON_SYSTEM_TESTEntities DB = new EXON_SYSTEM_TESTEntities())
            {
                try
                {
                    int currentnow = (int)DAO.ConvertDateTime.GetDateTimeServer().TimeOfDay.TotalSeconds;
                    int datenow = DAO.ConvertDateTime.ConvertDateTimeToUnix(DAO.ConvertDateTime.GetDateTimeServer()) / 86400;
                    //ROOMDIAGRAM RD = DB.ROOMDIAGRAMS.SingleOrDefault(x => x.ComputerName == ComputerName);
                    //if (RD != null)
                    //{
                        List<SHIFT> lstsh = DB.SHIFTS.Where(x => x.StartTime > 0 && x.ShiftDate / 86400 == datenow).OrderBy(x => x.StartTime).ToList();
                        foreach (SHIFT sh in lstsh)
                        {

                           

                            DIVISION_SHIFTS ds = DB.DIVISION_SHIFTS.Where(x => x.ShiftID == sh.ShiftID).SingleOrDefault();
                            if (ds != null && ds.Status != Common.STATUS_DIVISION_COMPLETE && ds.Status>=Common.STATUS_DIVISION_GENERATE)
                            {
                                C = new Contest();
                                C.ContestID = sh.CONTEST.ContestID;
                                C.ContestName = sh.CONTEST.ContestName;
                                C.RoomID = ds.RoomTestID;
                                C.RoomName = ds.ROOMTEST.RoomTestName;
                          
                                C.StartTime = ds.StartTime??default(int);
                                C.EndTime = ds.EndTime??default(int);
                                C.ShiftDate = ds.SHIFT.ShiftDate;
                                ContestOut = C;
                                break;
                            }
                            else
                            {
                                C = null;
                            }
                            
                        }
                        if (C!=null && C.ContestID>0)
                        {
                            ContestOut = C;
                            EC = new ErrorController(Common.STATUS_OK, "Nhận thông tin ca thi thành công");
                        }
                        else
                        {
                            ContestOut = null;
                            EC = new ErrorController(Common.STATUS_ERROR, "Ca thi trong ngày đã hết hoặc chưa bắt đầu");
                        }
                //    }
                    //else
                    //{
                    //    ContestOut = null;
                    //    EC = new ErrorController(Common.STATUS_ERROR, "Máy chưa được đăng ký!");
                    //    // trường hợp này lỗi do k lấy dc dữ liệu từ DB.
                    //}

                }
                catch 
                {
                    ContestOut = null;
                    EC = new ErrorController(Common.STATUS_UNKOWN_EXCEPTION, string.Format(Common.STR_STATUS_UNKOWN_EXCEPTION, "Có lỗi khi lấy dữ liệu"));
                    // đây là trường hợp lỗi khi sử dụng try catch thường sẽ là unknown
                }
            }
        }
        public int GetStatusDivisionShift(int _divisionShiftID, SqlConnection sql)
        {
            //try
            //{
            //    DIVISION_SHIFTS ds = new DIVISION_SHIFTS();
            //    using (EXON_SYSTEM_TESTEntities DB = new EXON_SYSTEM_TESTEntities())
            //    {
            //        ds = DB.DIVISION_SHIFTS.Where(x => x.DivisionShiftID == _divisionShiftID).SingleOrDefault();
            //        if (ds != null)
            //        return ds.Status;
            //        else
            //        {
            //            return -1;
            //        }
            //    }
            //}
            //catch 
            //{
            //    return -1;
            //}
            try
            {
                int status = -1;
                SqlCommand sqlcmd = new SqlCommand("SELECT status from DIVISION_SHIFTS where  DivisionShiftID=@id;", sql);
                sqlcmd.Parameters.Add("@id", _divisionShiftID);
                using (SqlDataReader reader = sqlcmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        status = int.Parse(reader["status"].ToString());
                    }

                }
                return status;
                //DIVISION_SHIFTS ds = new DIVISION_SHIFTS();
                //using (EXON_SYSTEM_TESTEntities DB = new EXON_SYSTEM_TESTEntities())
                //{
                //    ds = DB.DIVISION_SHIFTS.Where(x => x.DivisionShiftID == _divisionShiftID).SingleOrDefault();
                //    if (ds != null)
                //    return ds.Status;
                //    else
                //    {
                //        return -1;
                //    }
                //}
            }
            catch (Exception ex)
            {
                return -1;
            }

        }
        public void GetContestByComputerName(string ComputerName, out Contest ContestOut, out ErrorController EC)
        {
            Contest C = new Contest();
            using (EXON_SYSTEM_TESTEntities DB = new EXON_SYSTEM_TESTEntities())
            {
                try
                {
                    ROOMDIAGRAM RD = DB.ROOMDIAGRAMS.SingleOrDefault(x => x.ComputerName == ComputerName);

                    if (RD != null)
                    {
                        CONTESTANTS_SHIFTS CSH = RD.CONTESTANTS_SHIFTS.SingleOrDefault();
                        DIVISION_SHIFTS SS = RD.ROOMTEST.DIVISION_SHIFTS.SingleOrDefault(x => x.ShiftID == CSH.DIVISION_SHIFTS.ShiftID && x.RoomTestID == CSH.DIVISION_SHIFTS.RoomTestID);
                        if (SS != null && CSH != null)
                        {
                            //C.ContestID = SS.SHIFT.ContestID??default(int);
                            C.ContestName = SS.SHIFT.CONTEST.ContestName;
                            C.StartTime = SS.SHIFT.StartTime;
                            C.EndTime = SS.SHIFT.EndTime;
                            C.ShiftDate = SS.SHIFT.ShiftDate;
                            C.Subject = CSH.SCHEDULE.SUBJECT.SubjectName;
                            C.TimeOfTest = CSH.SCHEDULE.TimeOfTest + 300;
                            //  C.DivisionShiftID = CSH.DivisionShiftID;
                            C.RoomID = SS.RoomTestID;
                            C.RoomName = SS.ROOMTEST.RoomTestName;
                            C.ComputerCode = RD.ComputerCode;
                            C.ScheduleID = CSH.ScheduleID;
                            C.ComputerName = RD.ComputerName;
                            C.TimeToSubmit = CSH.SCHEDULE.TimeToSubmit;
                            C.TimeOfTest = CSH.SCHEDULE.TimeOfTest;
                            ContestOut = C;
                            EC = new ErrorController(Common.STATUS_OK, "Nhận thông tin ca thi thành công");
                             
                        }
                        else
                        {
                            ContestOut = null;
                            EC = new ErrorController(Common.STATUS_ERROR, "Không thể nhận SHIFTS_STAFFS bởi ComputerName");
                            // trường hợp này lỗi do k lấy dc dữ liệu từ DB.
                        }
                    }
                    else
                    {
                        ContestOut = null;
                        EC = new ErrorController(Common.STATUS_ERROR, "Không thể nhận ROOMDIAGRAMS bởi ComputerName");
                        // trường hợp này lỗi do k lấy dc dữ liệu từ DB.
                    }
                }
                catch (Exception ex)
                {
                    ContestOut = null;
                    EC = new ErrorController(Common.STATUS_UNKOWN_EXCEPTION, string.Format(Common.STR_STATUS_UNKOWN_EXCEPTION, ex.Message));
                    // đây là trường hợp lỗi khi sử dụng try catch thường sẽ là unknown
                }
            }
        }
    }
}
