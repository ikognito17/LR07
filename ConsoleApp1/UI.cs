using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class UI
    {
        public static void Print(Занятие занятие)
        {
            Console.WriteLine($"Занятие.ДатаПроведения = {занятие.ДатаПроведения}");
            Print(занятие.Дисциплина);
            Print(занятие.Сотрудник);
            Print(занятие.Аудитория);
            Print(занятие.Группа);
            Print(занятие.Пара);
            Print(занятие.ВидЗанятия);

        }
        public static void Print(Аудитория аудитория)
        {
            Console.WriteLine($"аудитория.Название = {аудитория.Название}");
            Print(аудитория.Сотрудник);
            Console.WriteLine($"аудитория.количествоПосадочных_мест = {аудитория.КоличествоПосадочныхМест}");
            Console.WriteLine($"аудитория.количествоОкон = {аудитория.КоличествоОкон}");

            foreach(Оборудование i in аудитория.СписокОборудования)
            {
                Print(i);
            }
        }
        public static void Print(ВидЗанятия видЗанятия)
        {
        }

        public static void Print(Должность должность)
        {
            Console.WriteLine($"должность.Имя = {должность.Название}");
            Console.WriteLine($"должность.Оклад = {должность.Оклад}");
            Print(должность.Подразделение);
        }
        public static void Print(Подразделение подразделение)
        {
        }
        public static void Print(Группа группа)
        {
            Console.WriteLine($"группа.Название = {группа.Название}");
            Console.WriteLine($"группа.Сокращение = {группа.Сокращение}");
            Console.WriteLine($"группа.Численность = {группа.Численность}");
            Console.WriteLine($"группа.ГодПоступления = { группа.ГодПоступления}");
            Print(группа.Специальность);
            Print(группа.КлассныйРуководитель);
        }
        public static void Print(Дисциплина дисциплина)
        {
            Console.WriteLine($"Дисциплина.Название = {дисциплина.Название}");
            Console.WriteLine($"Дисциплина.Сокращение = {дисциплина.Сокращение}");
        }
        public static void Print(Пара пара)
        {
            Console.WriteLine($"пара.BeginPara = {пара.BeginPara}");
            Console.WriteLine($"пара.EndPara = {пара.EndPara}");
            Console.WriteLine($"пара.BeginBreak = {пара.BeginBreak}");
            Console.WriteLine($"пара.EndBreak = {пара.EndBreak}");
            Print(пара.НоваяCмена);
        }
        public static void Print(Смена смена)
        {
            Console.WriteLine($"смена.Name = {смена.Name}");
        }
        public static void Print(Сотрудник сотрудник)
        {
            Console.WriteLine($"сотрудник.Фамилия = {сотрудник.Фамилия}");
            Console.WriteLine($"сотрудник.Имя = {сотрудник.Имя}");
            Console.WriteLine($"сотрудник.Отчество = {сотрудник.Отчество}");
            Print(сотрудник.Должность);
        }
        
        public static void Print(Оборудование оборудование)
        {
        }
        public static void Print(Специальность специальность)
        {
            Console.WriteLine($"специальность.Название = {специальность.Название}");
            Console.WriteLine($"специальность.Сокращение = {специальность.Сокращение}");
        }
        public static void Print(Студент студент)
        {
            Console.WriteLine($"студент.Фамилия = {студент.Фамилия}");
            Console.WriteLine($"студент.Имя = {студент.Имя}");
            Console.WriteLine($"студент.Отчество = {студент.Отчество}");
            Console.WriteLine($"студент.Дата_рождения = {студент.ДатаРождения.ToShortDateString()}");
            Print(студент.Группа);
        }

    }
}
