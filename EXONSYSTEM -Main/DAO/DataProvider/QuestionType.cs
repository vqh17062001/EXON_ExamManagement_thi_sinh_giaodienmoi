
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.DataProvider
{
	public class QuestionTypes
	{
		
		public int QuestionTypeID { get; set; }
		public string QuestionTypeName { get; set; }
		public string Description { get; set; }
		public bool IsSingleChoice { get; set; }
		public bool IsParagraph { get; set; }
		public bool IsQuestionContent { get; set; }
		public int NumberSubQuestion { get; set; }
		public int NumberAnswer { get; set; }
		public int Status { get; set; }
		public bool IsQuiz { get; set; }
		public int Type { get; set; }

		public QuestionTypes(){}
        // caau hoi  lớn
	

    }
}
