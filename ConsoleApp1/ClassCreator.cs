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
                    string название = Console.ReadLine();

                    Console.Write("Введите количесвто посадочных мест: ");
                    uint количесвтоПосадочныхМест = uint.Parse(Console.ReadLine());

                    Console.Write("Введите количесвто окон: ");
                    uint количесвтоОкон = uint.Parse(Console.ReadLine());

                    List<Оборудование> списокОборудования = new List<Оборудование>();

                    return new Аудитория(название, Сотрудник(), количесвтоПосадочныхМест, количесвтоОкон, списокОборудования);
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
            string название = Console.ReadLine();
            Console.WriteLine("Введите сокращение: ");
            string сокращение = Console.ReadLine();
            int численность;
            int годПоступления;
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите численность: ");
                    численность = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите год поступления: ");
                    годПоступления = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Числа!");                   
                }                
                                            
            }                    
            return new Группа(название, сокращение, численность, годПоступления, Специальность(), Сотрудник());
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
            try
            {
                Console.WriteLine("Введите начало пары. ");
                string timePara = Console.ReadLine();
                TimeSpan startPara = DateTime.Parse(timePara).TimeOfDay;
                
                Console.WriteLine("Введите конец пары: ");
                timePara = Console.ReadLine();
                TimeSpan endPara = DateTime.Parse(timePara).TimeOfDay;
                
                Console.WriteLine("Введите начало перемены: ");
                timePara = Console.ReadLine();
                TimeSpan startBreak = DateTime.Parse(timePara).TimeOfDay;
                
                Console.WriteLine("Введите конец перемены: ");
                timePara = Console.ReadLine();
                TimeSpan endBreak = DateTime.Parse(timePara).TimeOfDay;
                return new Пара(startPara, endPara, startBreak, endBreak, Смена());
            }
            catch (Exception) { return Пара(); }
        }
        public static Смена Смена()
        {
            Console.WriteLine("Введите название смены");
            string name = Console.ReadLine();
            return new Смена(name);
        }
        public static Должность Должность()
        {
            Console.Write("Введите название: ");
            string Название = Console.ReadLine();
            Console.Write("Введите оклад: ");
            string Оклад = Console.ReadLine();
            return new Должность(Название, Оклад, Подразделение());
        }
        public static Подразделение Подразделение()
        {
            return new Подразделение();
        }
        public static Сотрудник Сотрудник()
        {
            Console.WriteLine("Введите Фамилию: ");
            string фамилия = Console.ReadLine();
            Console.WriteLine("Введите Имя: ");
            string имя = Console.ReadLine();
            Console.WriteLine("Введите Отчество: ");
            string отчество = Console.ReadLine();
            return new Сотрудник(фамилия, имя, отчество, Должность());
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
        public static Студент Студент()
        {

            {
                Console.WriteLine("Введите фамилию: ");
                string Фамилия = Console.ReadLine();
                Console.WriteLine("Введите имя: ");
                string Имя = Console.ReadLine();
                Console.WriteLine("Введите отчество: ");
                string Отчество = Console.ReadLine();
                Console.WriteLine("Введите дату рождения формата dd.mm.yyyy: ");
                string ДатаРождения = Console.ReadLine();
                while (Фамилия == string.Empty || Имя == string.Empty || Отчество == string.Empty)
                {
                    Console.WriteLine("Параметры должны быть введены");
                    return Студент();
                }


                if (ДатаРождения == string.Empty)
                {

                    Console.WriteLine("Дата рождения не введена, установлена сегодняшняя дата");
                    ДатаРождения = DateTime.Today.ToString();
                    Console.WriteLine(Фамилия + " " + Имя + " " + Отчество + " " + ДатаРождения);
                    return new Студент(Фамилия, Имя, Отчество, Группа(), ДатаРождения);

                }

                string[] split = ДатаРождения.Split('.');
                string day = split[0];
                string month = split[1];
                string year = split[2];
                int day2 = Convert.ToInt32(day);
                int month2 = Convert.ToInt32(month);
                int year2 = Convert.ToInt32(year);
                while ((year2 < 1 || year2 > 2023) || (month2 < 1 || month2 > 12) || (day2 < 1 || day2 > 31) || (day2 > 28 && month2 == 2))
                {
                    Console.WriteLine("Введите дату правильно");
                    return Студент();
                }


                if ((year2 > 0 && year2 < 2024) && (month2 > 0 && month2 < 13) && (day2 > 0 && day2 < 32) && (day2 < 29 && month2 == 2))
                {
                    ДатаРождения = day2.ToString() + "." + month2.ToString() + "." + year2.ToString();

                }

                Console.WriteLine(Фамилия + " " + Имя + " " + Отчество + " " + ДатаРождения);
                return new Студент(Фамилия, Имя, Отчество, Группа(), ДатаРождения);
            }

        }
    }
}
