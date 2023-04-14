using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Дисциплина
    {
        public string Название { get; }
        public string Сокращение { get; }

        public Дисциплина(string название, string сокращение)
        {
            Название = название;
            Сокращение = сокращение;
        }
    }
}
