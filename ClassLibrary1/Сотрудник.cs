using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Сотрудник
    {
        public string Фамилия{ get;}
        public string Имя { get; }
        public string Отчество { get; }
        public Должность Должность { get; }
        public Сотрудник(string фамилия, string имя, string отчество, Должность должность)
        {
            Фамилия = фамилия;
            Имя=имя;
            Отчество=отчество;
            Должность=должность; 
        }
    }
}
