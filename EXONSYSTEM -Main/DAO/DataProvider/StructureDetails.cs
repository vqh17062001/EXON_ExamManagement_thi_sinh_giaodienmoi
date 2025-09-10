
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.DataProvider
{
	public class StructureDetails
	{
		
		public int StructureDetailID { get; set; }
		public int NumberQuestions { get; set; }
		public int Level { get; set; }
		public float Score { get; set; }
		public int Status { get; set; }
		public int StructureID { get; set; } 
		public int TopicID { get; set; }
	
		public StructureDetails() {}
        // caau hoi  lớn
	

    }
}
