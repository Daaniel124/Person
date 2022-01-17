using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Person
{
    public class Person
    {
        string fam;     // поле фамилия
        string status;  // поле статус
        int salary;     // поле зарплата
        int age;        // поле возраст 

        public Person() { }
        public Person(string fam)
        {
            this.fam = fam;
        }

        public string Fam  //свойство для поля фамилия
        {
            set { if (fam == null) fam = value; }     //код - установка значения поля фамилия
            get { return fam; }                     //код - чтение значения поля  фамилия
        }
        public int Age        //свойство для поля возраст
        {
            set                    //код - установка значения полей возраст и статус
            {
                age = value;
                if (age < 7) status = "ребенок";
                else if (age < 17) status = "школьник";
                else if (age < 22) status = "студент";
                else status = "служащий";

            }
            get { return (age); }       //код - чтение значения поля  возраст
        }
        public string Status  //свойство для поля статус
        {
            get { return status; }    // код - чтение поля статус
        }
        public int Salary  //свойство для поля зарплата
        {
            get { return salary; }  //код - чтение поля зарплата
            set { salary = value; }   //код - установка поля зарплата
        }
        public void Show()  // метод вывода значений полей
        {
            Console.WriteLine("Фамилия " + fam);
            Console.WriteLine("Возраст " + age);
            Console.WriteLine("Статус " + status);
            Console.WriteLine("Зарплата " + salary);
        }
    }
}
