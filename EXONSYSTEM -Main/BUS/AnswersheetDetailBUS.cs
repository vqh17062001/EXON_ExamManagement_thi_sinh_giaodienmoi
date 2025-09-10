using DAO.DAO;
using DAO.DataProvider;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
	public class AnswersheetDetailBUS
	{
		private static AnswersheetDetailBUS instance;
		public static AnswersheetDetailBUS Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new AnswersheetDetailBUS();
				}
				return instance;
			}
		}
		private AnswersheetDetailBUS() { }
		public void PushAnswerSheetDetail(AnswersheetDetail ansSheetDetail, out ErrorController EC, SqlConnection sql)
		{
			AnswersheetDetailDAO.Instance.PushAnswerSheetDetail(ansSheetDetail, out EC, sql);
		}
		public void GetListAnswerSheetDetail(ContestantInformation CI, out List<AnswersheetDetail> rListASD, SqlConnection sql)
		{
			AnswersheetDetailDAO.Instance.GetListAnswerSheetDetail(CI, out rListASD, sql);
		}
	}
}
