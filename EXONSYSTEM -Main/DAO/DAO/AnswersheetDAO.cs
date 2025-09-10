using DAO;
using DAO.DataProvider;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.DAO
{
	public class AnswersheetDAO
	{
		private static AnswersheetDAO instance;
		public static AnswersheetDAO Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new AnswersheetDAO();
				}
				return instance;
			}
		}
		private AnswersheetDAO() { }

		public void PushAnswerSheet(Answersheet ansSheet, out ErrorController EC,SqlConnection sql)
		{
			using (EXON_SYSTEM_TESTEntities db = new EXON_SYSTEM_TESTEntities())
			{
				try
				{
					ANSWERSHEET ASH = db.ANSWERSHEETS.SingleOrDefault(x => x.ContestantTestID == ansSheet.ContestantTestID);
					if (ASH != null)
					{
                        //if (ansSheet.TestScores != null)
                        //{
                        //	ASH.TestScores = ansSheet.TestScores;
                        //}
                        //if (anssheet.essaypoints != null)
                        //{
                        //	ash.essaypoints = anssheet.essaypoints;
                        //}
                        //ASH.Status = Common.STATUS_CHANGED;
                        //db.Entry(ASH).State = EntityState.Modified;
                        //db.SaveChanges();
                        SqlCommand sqlcmd = new SqlCommand("update   ANSWERSHEETS set TestScores=@TestScores,EssayPoints=@EssayPoints where AnswerSheetID=@id;", sql);
						
						sqlcmd.Parameters.Add("@id", ASH.AnswerSheetID);
						sqlcmd.Parameters.Add("@TestScores", ansSheet.TestScores ?? (object)DBNull.Value);
						sqlcmd.Parameters.Add("@EssayPoints", ansSheet.EssayPoints ?? (object)DBNull.Value);
						int row = 0;
						while (row == 0)
						{
							row = sqlcmd.ExecuteNonQuery();

						}
						
						EC = new ErrorController(Common.STATUS_OK, "Cập nhật ANSWERSHEET thành công");
					}
					else
					{
						SqlCommand sqlcmd = new SqlCommand("INSERT INTO ANSWERSHEETS(ContestantTestID,TestScores,Status) values (@ContestantTestID,@TestScores,@Status) ;", sql);

						sqlcmd.Parameters.Add("@ContestantTestID", ansSheet.ContestantTestID);
						sqlcmd.Parameters.Add("@TestScores", ansSheet.TestScores ?? (object)DBNull.Value);
						sqlcmd.Parameters.Add("@Status", Common.STATUS_INITIALIZE);
						int row = 0;
						while (row == 0)
						{
							row = sqlcmd.ExecuteNonQuery();

						}
						//	ANSWERSHEET dbAnsSheet = new ANSWERSHEET();
						//	dbAnsSheet.ContestantTestID = ansSheet.ContestantTestID;
						////	dbAnsSheet.EssayPoints = ansSheet.EssayPoints;
						//	dbAnsSheet.TestScores = ansSheet.TestScores;
						//	dbAnsSheet.Status = Common.STATUS_INITIALIZE;
						//	db.ANSWERSHEETS.Add(dbAnsSheet);
						//	db.SaveChanges();
						EC = new ErrorController(Common.STATUS_OK, "Thêm mới ANSWERSHEET thành công");
					}
				}
				catch(Exception ex)
				{
					EC = new ErrorController(Common.STATUS_UNKOWN_EXCEPTION, string.Format(Common.STR_STATUS_UNKOWN_EXCEPTION, ex.Message));
				}
			}
		}
		public void GetAnswerSheetByContestantID(ContestantInformation CI, out Answersheet ansDOut, out ErrorController EC)
		{
			Answersheet ans = new Answersheet();
			using (EXON_SYSTEM_TESTEntities db = new EXON_SYSTEM_TESTEntities())
			{
				try
				{
					ANSWERSHEET rDBAnsSheet = db.ANSWERSHEETS.SingleOrDefault(x => x.ContestantTestID == CI.ContestantTestID);                  
					if (rDBAnsSheet != null)
					{
						ans.AnswerSheetID = rDBAnsSheet.AnswerSheetID;
						ans.ContestantTestID = rDBAnsSheet.ContestantTestID;
						ans.Status = rDBAnsSheet.Status;
						ans.EssayPoints = rDBAnsSheet.EssayPoints ?? default(float);
						if(rDBAnsSheet.TestScores.HasValue)
                            ans.TestScores =(float) rDBAnsSheet.TestScores.Value;

						ansDOut = ans;
						EC = new ErrorController(Common.STATUS_OK, "Nhận AnswerSheetByContestantID thành công");
					}
					else
					{
						ansDOut = null;
						//EC = new ErrorController(Common.STATUS_ERROR, "Không thể nhận AnswerSheetByContestantID");
                        EC = new ErrorController(Common.STATUS_ERROR, "Thí sinh không tải được đề");
                    }
				}
				catch(Exception ex)
				{
					ansDOut = null;
					EC = new ErrorController(Common.STATUS_UNKOWN_EXCEPTION, string.Format(Common.STR_STATUS_UNKOWN_EXCEPTION, ex.Message));
				}
			}
		}
	}
}
