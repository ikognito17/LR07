using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("Введите название класса: ");
                switch (Console.ReadLine())
                {
                    case "Сотрудник": UI.Print(ClassCreator.Сотрудник()); break;
                    case "Занятие": UI.Print(ClassCreator.Занятие()); break;
                    case "Аудитория": UI.Print(ClassCreator.Аудитория()); break;
                    case "Дисциплина": UI.Print(ClassCreator.Дисциплина()); break;
                    case "Группа": UI.Print(ClassCreator.Группа()); break;
                    case "Специальность": UI.Print(ClassCreator.Специальность()); break;
                    case "Пара": UI.Print(ClassCreator.Пара()); break;
                    case "Должность": UI.Print(ClassCreator.Должность()); break;
                    case "Студент": UI.Print(ClassCreator.Студент()); break;
                    case "Смена": UI.Print(ClassCreator.Смена()); break;
                    default: Console.WriteLine("Такой класс не реализован"); break;
                }

            }
        }
    }
}
