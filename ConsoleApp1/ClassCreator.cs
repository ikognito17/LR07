using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApp1
{
    static class ClassCreator
    {
        public static Занятие Занятие()
        {
            Console.WriteLine($"Введите текущую дату: ");
            string ДатаПроведения = Console.ReadLine();
            return new Занятие(ДатаПроведения, Дисциплина(), Сотрудник(), Аудитория(), Группа(), Пара(), ВидЗанятия());
        }
        public static Аудитория Аудитория()
        {
            for (uint i = 0; i < 1; i++)
                try
                {
                    Console.Write("Введите название: ");
                    string Название = Console.ReadLine();

                    Console.Write("Введите количесвто посадочных мест: ");
                    uint Количесвто_посадочных_мест = uint.Parse(Console.ReadLine());

                    Console.Write("Введите количесвто окон: ");
                    uint Количесвто_окон = uint.Parse(Console.ReadLine());

                    return new Аудитория(Название, Сотрудник(), Количесвто_посадочных_мест, Количесвто_окон, Оборудование());
                }
                catch (Exception)
                {
                    --i;
                }
            return null;
        }
        public static ВидЗанятия ВидЗанятия()
        {
            return new ВидЗанятия();
        }
        public static Группа Группа()
        {
            Console.WriteLine("Введите название: ");
            string Название = Console.ReadLine();
            Console.WriteLine("Введите сокращение: ");
            string Сокращение = Console.ReadLine();
            Console.WriteLine("Введите численность: ");
            string Численность = Console.ReadLine();
            Console.WriteLine("Введите год поступления: ");
            string Год_поступления = Console.ReadLine();
            return new Группа(Название, Сокращение, Численность, Год_поступления, Специальность(), Сотрудник());
        }
        public static Дисциплина Дисциплина()
        {
            Console.WriteLine("Введите название дисциплины: ");
            string Название = Console.ReadLine();

            Console.WriteLine("Введите сокращенное название дисциплины: ");
            string Сокращение = Console.ReadLine();
            return new Дисциплина(Название, Сокращение);
        }
        public static Пара Пара()
        {
            return new Пара();
        }
        public static Должность Должность()
        {
            return new Должность();
        }
        public static Сотрудник Сотрудник()
        {
            Console.WriteLine("Введите Фамилию: ");
            string Фамилия = Console.ReadLine();
            Console.WriteLine("Введите Имя: ");
            string Имя = Console.ReadLine();
            Console.WriteLine("Введите Отчество: ");
            string Отчество = Console.ReadLine();
            return new Сотрудник(Фамилия,Имя,Отчество,Должность());
        }
        public static Оборудование Оборудование()
        {
            return new Оборудование();
        }
        public static Специальность Специальность()
        {
            Console.WriteLine("Введите название: ");
            string Название = Console.ReadLine();
            Console.WriteLine("Введите сокращение: ");
            string Сокращение = Console.ReadLine();
            return new Специальность(Название, Сокращение);
        }
    }
}
