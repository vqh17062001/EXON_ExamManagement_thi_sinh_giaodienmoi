using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.DataProvider
{
    public   class PartOfTest
    {
       
        public string PartContent { get; set; }
        public int Index { get; set; }
        public PartOfTest() { }
        public PartOfTest( string _PartContent, int _index)
        {
            PartContent = _PartContent;
            Index = _index;
            
        }
    }
}
