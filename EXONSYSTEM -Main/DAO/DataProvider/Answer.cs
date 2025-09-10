using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.DataProvider
{
	public class Answer
	{
		public int AnswerID { get; set; }
		public string AnswerContent { get; set; }
        public int HighToDisplay { get; set; }
		public bool IsCorrect { get; set; }
		public int SubQuestionID { get; set; }
		public Nullable<double> Score { get; set; }

		public Answer() { }
		public Answer(int answerID, string answerContent , int highToDisplay, bool isCorrect, int subQuestionID, double score)
		{
			AnswerID = answerID;
			AnswerContent = answerContent;
            HighToDisplay = highToDisplay;
			IsCorrect = isCorrect;
			SubQuestionID = subQuestionID;
			Score = score;
		}
	}
}
