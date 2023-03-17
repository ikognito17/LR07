using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Аудитория
    {
        public string Название { get; }

        public Сотрудник Сотрудник { get; }

        public uint КоличествоПосадочныхМест { get; }

        public uint КоличествоОкон { get; }

        public List<Оборудование> СписокОборудования { get; }

        public Аудитория(string название, Сотрудник сотрудник, uint количествоПосадочныхМест, uint количествоОкон, List<Оборудование> списокОборудования)
        {
            Название = название;
            Сотрудник = сотрудник;
            КоличествоПосадочныхМест = количествоПосадочныхМест;
            КоличествоОкон = количествоОкон;
            СписокОборудования = списокОборудования;
        }
    }
}
