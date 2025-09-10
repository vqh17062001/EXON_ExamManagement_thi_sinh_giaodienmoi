
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.DataProvider
{
	public class Questions
	{
		public int NO { get; set; }
		public int QuestionID { get; set; }
		public int SubQuestionID { get; set; }
		public string TitleOfQuestion { get; set; }
        
		public List<Answer> ListAnswer { get; set; }
        public int Type { get; set; }
       
        public int NumberQuestion { get; set; }
        public byte[] Audio { get; set; }

		//public string AnswerA { get; set; }
		//public int AnswerAID { get; set; }
		//public string AnswerB { get; set; }
		//public int AnswerBID { get; set; }
		//public string AnswerC { get; set; }
		//public int AnswerCID { get; set; }
		//public string AnswerD { get; set; }
		//public int AnswerDID { get; set; }
		public int FormatQuestion { get; set; }
		public int AnswerChecked { get; set; }
		public int TestID { get; set; }
		public int TestDetailID { get; set; }
		public bool IsSingleChoice { get; set; }
        public string AnswerSheetContent { get; set; }
        public bool IsQuestionContent { get; set; }
        public int HighToDisplayForQuestion { get; set; }
        public int HighToDisplayForSubQuestion { get; set; }

        public float Score { get; set; }

		/// <summary>
		/// Thuộc tính được thêm vào để phục vụ tính điểm bonus
		/// </summary>
		public Nullable<int> TopicID { get; set; }
		//public Nullable<int> QuestionTypeID { get; set; }
		public int numOfCorrectSubquestions = 0;

		public Questions()
		{
			this.ListAnswer = new List<Answer>();
		}
        // caau hoi  lớn
		public Questions(string title, int formatQuestion,int HighToDisplay, int testDetailID)
		{
            
            this.ListAnswer = new List<Answer>();
			this.TitleOfQuestion = title;
			this.FormatQuestion = formatQuestion;
			this.AnswerChecked = -1;
            this.HighToDisplayForQuestion = HighToDisplay;
			this.TestDetailID = testDetailID;
		}
        public Questions(byte[] _Audio,int questionID, int testDetailID, int formatQuestion,int type)
        {
            this.Type = type;
			this.TestDetailID = testDetailID;
			this.QuestionID = questionID;
            this.ListAnswer = new List<Answer>();
            this.Audio = _Audio;
            this.FormatQuestion = formatQuestion;
            this.AnswerChecked = -1;
        }

    }
}
