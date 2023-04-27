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
            decimal Оклад =Convert.ToDecimal( Console.ReadLine());
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
            Console.WriteLine("Введите фамилию: ");
            string фамилия = Console.ReadLine();
            Console.WriteLine("Введите имя: ");
            string имя = Console.ReadLine();
            Console.WriteLine("Введите отчество: ");
            string отчество = Console.ReadLine();
            Console.WriteLine("Введите дату рождения формата dd.mm.yyyy: ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime датаРождения))
            {
                return new Студент(фамилия, имя, отчество, Группа(), датаРождения);
            }
            else
            {
                return new Студент(фамилия, имя, отчество, Группа());
            }
        }
       
    }
}
