using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Занятие
    {
        public string ДатаПроведения { get; }
        public Дисциплина Дисциплина { get; }
        public Сотрудник Сотрудник { get; }
        public Аудитория Аудитория { get; }
        public Группа Группа { get; }
        public Пара Пара { get; }
        public ВидЗанятия ВидЗанятия { get; }
        public Занятие (string датаПроведения, Дисциплина дисциплина, Сотрудник сотрудник, Аудитория аудитория, Группа группа, Пара пара, ВидЗанятия видЗанятия)
        {
            ДатаПроведения = датаПроведения;
            Дисциплина = дисциплина;
            Сотрудник = сотрудник;
            Аудитория = аудитория;
            Группа = группа;
            Пара = пара;
            ВидЗанятия = видЗанятия;
        }


    }
}
