using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Пара
    {
        public string BeginPara { get; }
        public string EndPara { get; }
        public string BeginBreak { get; }
        public string EndBreak { get; }
        public Смена НоваяCмена { get; }

        public Пара() : this(DateTime.Now, DateTime.Now, DateTime.Now, DateTime.Now, new Смена()) 
        {

        }
        public Пара(DateTime bP, DateTime eP, DateTime bB, DateTime eB, Смена смена) {
            BeginPara = bP == null ? DateTime.Now.ToShortTimeString() : bP.ToShortTimeString();
            EndPara = eP == null ? DateTime.Now.ToShortTimeString() : eP.ToShortTimeString();
            BeginBreak = bB == null ? DateTime.Now.ToShortTimeString() : bB.ToShortTimeString();
            EndBreak = eB == null ? DateTime.Now.ToShortTimeString() : eB.ToShortTimeString();
            НоваяCмена = смена;
        }    
    }
}
