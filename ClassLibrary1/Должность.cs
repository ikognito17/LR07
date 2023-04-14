using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Должность
    {
        public string Название { get; }
        public decimal Оклад { get; }
        public Подразделение Подразделение { get; }


        public Должность(string название, decimal оклад, Подразделение подразделение)
        {
            this.Название = название;
            this.Оклад = оклад;
            this.Подразделение = подразделение;
        }
    }
}
