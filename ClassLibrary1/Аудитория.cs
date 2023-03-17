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

        public uint Количество_посадочных_мест { get; }

        public uint Количество_окон { get; }

        public Оборудование Оборудование { get; }

        public Аудитория(string название, Сотрудник сотрудник, uint количество_посадочных_мест, uint количество_окон, Оборудование оборудование)
        {
            Название = название;
            Сотрудник = сотрудник;
            Количество_посадочных_мест = количество_посадочных_мест;
            Количество_окон = количество_окон;
            Оборудование = оборудование;
        }
    }
}
