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
        public TimeSpan BeginPara { get; }
        public TimeSpan EndPara { get; }
        public TimeSpan BeginBreak { get; }
        public TimeSpan EndBreak { get; }
        public Смена НоваяCмена { get; }

        public Пара(TimeSpan bP, TimeSpan eP, TimeSpan bB, TimeSpan eB, Смена смена) {
            BeginPara = bP;
            EndPara = eP;
            BeginBreak = bB;
            EndBreak = eB;
            НоваяCмена = смена;
        }    
    }
}
