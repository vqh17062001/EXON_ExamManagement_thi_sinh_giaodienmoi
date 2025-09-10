
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.DataProvider
{
	public class StructureDetailBouns
	{
		
		public int StructureSubjectDetailBonusID { get; set; }
		public int StructureDetailID { get; set; }
		public int From { get; set; }
		public int To { get; set; }
		public decimal Bonus { get; set; } 
		
	
		public StructureDetailBouns() {}
        // caau hoi  lớn
	

    }
}
