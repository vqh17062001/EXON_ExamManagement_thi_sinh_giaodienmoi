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
	public class TestBUS
	{
		private static TestBUS instance;
		public static TestBUS Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new TestBUS();
				}
				return instance;
			}
		}
		private TestBUS() { }
		public void UpdateTimeForAudioQuestion(int TestDetailID, int QuestionFormat, SqlConnection sql)
		{
			TestDAO.Instance.UpdateTimeForAudioQuestion(TestDetailID, QuestionFormat, sql);
		}
		public void GetListLQuestionByContestantInformation(ContestantInformation CI, out List<List<Questions>> rLstQuest, out List<PartOfTest> lstPartOfTest, out bool IsContinute, out int numberQuestionsOfTest, out ErrorController EC, SqlConnection sql)
		{
			TestDAO.Instance.GetListQuestionByContestantInformation(CI, out rLstQuest, out lstPartOfTest, out IsContinute, out numberQuestionsOfTest, out EC, sql);
		}
		public float CheckAnswers(AnswersheetDetail ad, List<List<Questions>> lstLQuestion, SqlConnection sql)
		{
			return TestDAO.Instance.CheckAnswers(ad, lstLQuestion, sql);
		}
		public float SumScore(ContestantInformation CI, SqlConnection sql)
		{
			return TestDAO.Instance.SumScore(CI, sql);
		}

	}
}
