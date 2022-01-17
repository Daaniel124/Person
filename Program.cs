using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Manager mg = new Manager();
            mg.Fam = "Loginov";
            mg.Company = "TTHK";
            Console.WriteLine("Работник: " + mg.Fam + ", работодатель: " + mg.Company);
            Manager mg2 = new Manager("Petrov", "Apple", 10000);
            mg2.Show();
            Console.WriteLine("******");

            Manager[] mgs = new Manager[5];
            for (int x = 0; x < 5; x++)
            {
                mgs[x] = new Manager();
                Console.WriteLine("Ваше имя: ");
                mgs[x].Fam = Console.ReadLine();
                Console.WriteLine("Фирма, где вы работаете: ");
                mgs[x].Company = Console.ReadLine();
                Console.WriteLine("Стоимость продажи: ");
                mgs[x].Sale = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("******");
            foreach (var item in mgs)
            {
                item.Show();
            }
            Console.WriteLine("******");

            int n = 0, i;
            Person[] pr = new Person[10];          //объявляем массив на 10 объектов класса Person
            for (i = 0; i < 10; i++)
            { pr[i] = new Person(); }     // создаем 10 объектов
            String s, subkey, key;
            do                               // выводим меню для работы с программой
            {
                Console.WriteLine("***Меню***");
                Console.WriteLine("1 - Ввод данных");
                Console.WriteLine("2 - Вывод данных");
                Console.WriteLine("3 - Поиск данных по возрасту");
                Console.WriteLine("4 - Выход");
                Console.WriteLine();
                Console.WriteLine("Ваш выбор...");
                key = Console.ReadLine();
                switch (key)
                {
                    case "1":               // ввод данных выполняется через соответствующие свойства
                        do
                        {

                            Console.WriteLine("Введите фамилию: ");
                            s = Console.ReadLine(); pr[n].Fam = s;
                            Console.WriteLine("Введите возраст: ");
                            s = Console.ReadLine(); pr[n].Age = int.Parse(s);
                            Console.WriteLine("Введите зарплату: ");
                            s = Console.ReadLine(); pr[n].Salary = int.Parse(s);
                            n++;                               // количество инициализорованных объектов
                            Console.WriteLine("Продолжить?(Y/N)...");
                            subkey = Console.ReadLine();
                        } while (subkey.ToLower() == "y"); break;
                    case "2":               // вывод данных
                        for (i = 0; i < n; i++)
                        {
                            pr[i].Show();
                            Console.WriteLine();
                        }
                        break;
                    case "3":             // поиск данных по указанному возрасту
                        {
                            bool tr = true;
                            Console.WriteLine("Введите возраст для поиска: ");
                            s = Console.ReadLine(); int num = int.Parse(s);
                            for (i = 0; i < n; i++)
                                if (pr[i].Age == num)
                                {
                                    Console.WriteLine("Фамилия: {0}, возраст: {1}, статус: {2}",
                                     pr[i].Fam, pr[i].Age, pr[i].Status);
                                    tr = false;
                                    Console.WriteLine();
                                }
                            if (tr) Console.WriteLine("С таким возрастом нет человека!");
                            Console.WriteLine();
                        }
                        break;
                }
            } while (key != "4");
        }
    }
}
