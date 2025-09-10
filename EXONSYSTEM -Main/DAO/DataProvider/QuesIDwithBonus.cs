using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAO.DataProvider
{
     public class QuesIDwithBonus
    {
        //QUESTIONS.QuestionID, SDB.[From], SDB.[To], SDB.Bonus    

        public int QuestionID;
        public Nullable<int> From;
        public Nullable<int> To;
        public Nullable<decimal> Bonus;

        public QuesIDwithBonus() { }

        public QuesIDwithBonus(System.Data.DataRow row) {

            this.QuestionID = Convert.ToInt32(row["QuestionID"]);
       

            this.From = row["From"] as Nullable<int> != null ? Convert.ToInt32(row["From"]) : default(Nullable<int>);
            this.To = row["To"] as Nullable<int> != null ? Convert.ToInt32(row["To"]) : default(Nullable<int>);
            this.Bonus = row["Bonus"] as Nullable<decimal> != null ? Convert.ToDecimal(row["Bonus"]) : default(Nullable<decimal>);

        }
    }

    
}
