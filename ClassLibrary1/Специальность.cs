using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Специальность
    {
        public string Название { get; }
        public string Сокращение { get; }
        public Специальность(string название, string сокращение)
        {
            Название = название;
            Сокращение = сокращение;
        }
    }
}
