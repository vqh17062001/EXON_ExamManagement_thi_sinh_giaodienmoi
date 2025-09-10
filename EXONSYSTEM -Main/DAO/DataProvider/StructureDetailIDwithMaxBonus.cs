using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAO.DataProvider
{
     public class StructureDetailIDwithMaxBonus
    {
        public int NumOfQuestionInTest;

        int StructureDetailID;

        public Nullable<decimal> maxBonus;

        public StructureDetailIDwithMaxBonus() { }


        public StructureDetailIDwithMaxBonus(System.Data.DataRow row) {

            this.StructureDetailID = Convert.ToInt32(row["StructureDetailID"]);

            this.NumOfQuestionInTest = Convert.ToInt32(row["NumOfQuestionInTest"]);

            this.maxBonus = row["maxBonus"] as Nullable<decimal> != null ? Convert.ToDecimal(row["maxBonus"]) : default(Nullable<decimal>);
        }


    }
}
