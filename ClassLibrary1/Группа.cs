using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Группа
    {
        public string Название { get; }
        public string Сокращение { get; }
        public string Численность { get; }
        public string Год_поступления { get; }
        public Специальность Специальность { get; }
        public Сотрудник Классный_руководитель { get; }
        public Группа(string название, string сокращение, string численность, string год_поступления, Специальность специальность, Сотрудник классный_руководитель)
        {
            Название = название;
            Сокращение = сокращение;
            Численность = численность;
            Год_поступления = год_поступления;
            Специальность = специальность;
            Классный_руководитель = классный_руководитель;
        }
    }
}
