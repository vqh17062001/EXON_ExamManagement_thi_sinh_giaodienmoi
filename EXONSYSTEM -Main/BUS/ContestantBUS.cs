using UserHelper;
using DAO;
using DAO.DAO;
using DAO.DataProvider;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
	public class ContestantBUS
	{
		private static ContestantBUS instance;
		public static ContestantBUS Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new ContestantBUS();
				}
				return instance;
			}
		}
		private ContestantBUS() { }
        public void HandleDivisionShiftNext(int ContestantID, out Contest rC, out ContestantInformation rCI, out ErrorController EC)
        {
            ContestantDAO.Instance.HandleDivisionShiftNext(ContestantID, out  rC, out rCI,out EC);
        }
        public void GetListContestantPause(int ContestantShiftID, out List<CONTESTANTPAUSE> lstCP)
        {
            ContestantDAO.Instance.GetListContestantPause(ContestantShiftID, out lstCP);
        }
        public int GetThoiGianBu(int ContestantShiftID)
        {
           return ContestantDAO.Instance.GetThoiGianBu(ContestantShiftID);

        }
        public void UpdateLastimeConnect(int ContestantShiftID, int Lasttime,  SqlConnection sql)
        {
            ContestantDAO.Instance.UpdateLastimeConnect(ContestantShiftID,Lasttime, sql);
        }
        public void UpdateForContestantPause(int ContestantShiftID, out ErrorController EC,out int ThoiGianBu,SqlConnection sql)
        {
            ContestantDAO.Instance.UpdateForContestantPause(ContestantShiftID,out EC,out ThoiGianBu,sql);
        }
        public void Authen(Contest C, string ContestantCode, string ComputerName, int LoginType, out ContestantInformation rCI, out ErrorController EC, SqlConnection sql)
		{
			ContestantDAO.Instance.Authen(C, ContestantCode, ComputerName, LoginType, out rCI, out EC,sql);
		}
        public void ChangeStatusContestant(ContestantInformation CI, Contest C, out ErrorController EC, SqlConnection sql)
		{
            ContestantDAO.Instance.ChangeStatusContestant(CI, C, out EC, sql) ; ;
		}
		public void GetContestantTestInformation(ContestantInformation CI, out ContestantInformation rCI, out ErrorController EC)
		{
			ContestantDAO.Instance.GetContestantTestInformation(CI, out rCI, out EC);
		}
        public int GetStatusContestantShift(int _contestantShiftID)
        {
            return ContestantDAO.Instance.GetStatusContestantShift(_contestantShiftID);
        }
        public void GetContestantTimeStart(ContestantInformation CI, out ContestantInformation rCI, out ErrorController EC)
        {
            ContestantDAO.Instance.GetContestantTimeStart(CI, out rCI, out EC);
        }

        public string GetConnectStringSqlDenpendecy()
        {
                return  ContestantDAO.Instance.GetConnectStringSqlDenpendecy();
        }

        public int GetTimeStartFromContestant(int contestantShiftID)
        {
            return ContestantDAO.Instance.GetTimeStartFromContestant(contestantShiftID);
        }
        public int GetTimeStartFromAnswer(int AnswersheetID)
        {
            return ContestantDAO.Instance.GetTimeStartFromAnswer(AnswersheetID);
        }
        public int GetTimeOfTestFromAnswer(int AnswersheetID)
        {
            return ContestantDAO.Instance.GetTimeOfTestFromAnswer(AnswersheetID);
        }
        public void ChangeContestantCode(UserLoginComputerDifferent ULCD, ContestantInformation CI, SqlConnection sql)
        {
            ContestantDAO.Instance.ChangeContestantCode(ULCD, CI, sql);
        }

        public int GetNumberOfOvertime(ContestantInformation CI, SqlConnection sql)
        {
            return ContestantDAO.Instance.GetNumberOfOvertime(CI, sql);
        }
    }
}
