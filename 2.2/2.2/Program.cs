//1 ZADANIE
/*using System;
using System.Runtime.InteropServices;

namespace egorLoh
{
    class Student
    {
        public Student(string sur, string b, int n, int[] m)
        {
            this.surname = sur;
            this. birhtday = Convert.ToDateTime(b);
            this.numGr = n;
            this.marks = m;

        }
        public string surname = " ";
        public DateTime birhtday;
        public int numGr;
        public int[] marks = new int[5];

        public void Info() 
        {
            Console.WriteLine($"Фамилия: {surname}");
            Console.WriteLine($"Дата рождения: {birhtday}");
            Console.WriteLine($"Номер группы: {numGr}");
            Console.WriteLine($"Оценки: {string.Join(", ", marks)}");
        }

    }
    class egorLoh2
    {
        static void Main()
        {
            int[] marks = new int[] { 3, 2, 2, 2, 1 };
            Student stud1 = new Student("Пупкин", "26.08.2005", 612, marks);
            int a = -1;
            while(a != 0)
            {
                Console.WriteLine("Выберите опцию\n\n1 - вывод информации о студенте\n2 - изменениие фамилии\n3 - изменить дату рождения\n4 - Изменить номер группы\n0 - выход ");
                a = Convert.ToInt32(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        stud1.Info();
                        break;
                        case 2:
                        Console.WriteLine("Введите новую фамилию: ");
                        string surname2 = Console.ReadLine();
                        stud1.surname= surname2;
                        break;
                        case 3:
                        Console.WriteLine("Введите дату рождения: ");
                        DateTime birh = Convert.ToDateTime(Console.ReadLine());
                        stud1.birhtday = birh; 
                        break; 
                        case 4:
                        Console.WriteLine("Введите новый номер группы: ");
                        int num1 = Convert.ToInt32(Console.ReadLine());
                        stud1.numGr = num1;
                        break;
                        case 0:
                        return;
                }
            }
        }
    }

}*/




//2ZADANIE
/*using System;
using System.Runtime.InteropServices;

namespace ConsoleApp
{
    class Train
    {
        public Train(string name, int num, string b)
        {
            this.itemname = name;
            this.numtrain = num;
            this.number = Convert.ToDateTime(b);
        }
        public string itemname = " ";
        public DateTime number;
        public int numtrain;

        public void Info()
        {
            Console.WriteLine($"Название пункта назначения: {itemname}");
            Console.WriteLine($"Номер поезда: {number}");
            Console.WriteLine($"Время отправления: {numtrain}");
        }
    }
    class egorLoh2
    {
        static void Main()
        {
        Train tr1 = new Train("Светлый", 1, "21.02.2021 12:00:21");
        Train tr2 = new Train("Светлый2", 2, "23.02.2022");
        Train tr3 = new Train("Светлый3", 3, "24.02.2021");
        Train tr4 = new Train("Светлый4", 4, "25.02.2023");
        Train tr5 = new Train("Светлый5", 5, "26.02.2023");

         
                Console.WriteLine("Выберите поезд от 1 до 5 ");
                int a = Convert.ToInt32(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        tr1.Info();
                        break;
                    case 2:
                        tr2.Info();
                        break;
                    case 3:
                        tr3.Info();
                        break;
                    case 4:
                        tr4.Info();
                        break;
                    case 5:
                        tr5.Info();
                        break;
                        default:
                        Console.WriteLine("Такого поезда не существует");
                        return;
                }
            }
        }
    }*/





//3ZADANIE
/*using System;

namespace NumbersTask3
{
    class Number
    {
        public int num1;
        public int num2;

        public void DisplayInfo()
        {
            Console.WriteLine($"Первое число: {num1}");
            Console.WriteLine($"Второе число: {num2}");
        }
        public Number(int switchNum1, int switchNum2)
        {
            this.num1 = switchNum1;
            this.num2 = switchNum2;
        }
        public int sumNumbers(int a, int b)
        {
            int sumNumbers = a + b;
            return sumNumbers;
        }
        public int GreatestNum(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
    }
    class Task3
    {
        static void Main()
        {
            Console.Write("Введите первое число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Number numbers = new Number(a, b);
            Console.WriteLine("Выберите вкладку:\n\n1 - Вывод чисел\n2 - Сумма чисел\n3 - Наибольшее число\n0 - Ничего");
            int menu = Convert.ToInt32(Console.ReadLine());
            switch (menu)
            {
                case 1:
                    numbers.DisplayInfo();
                    break;
                case 2:
                    Console.WriteLine($"Сумма: {numbers.sumNumbers(a, b)}");
                    break;
                case 3:
                    Console.WriteLine($"Наибольшее число: {numbers.GreatestNum(a, b)}");
                    break;
                case 0:
                    return;
                default:
                    Console.WriteLine("Такой вкладки нет в меню");
                    return;
            }
        }
    }
}*/







//4 ZADANIE

/*using System;
class Counter
{
    private int value;

    public Counter()
    {
        value = 0;
    }

    public Counter(int initialValue)
    {
        value = initialValue;
    }

    public void Increment()
    {
        value++;
    }

    public void Decrement()
    {
        value--;
    }

    public int Value
    {
        get { return value; }
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Введите число: ");
        int a = Convert.ToInt32(Console.ReadLine());

        var myCounter = new Counter(a);

        while (true)
        {
            Console.Write("\n0 для выхода из программы\n1 для увеличения\n2 для уменьшения\n3 для вывода: ");
            int b = Convert.ToInt32(Console.ReadLine());
            switch (b)
            {
                case 0:
                    Console.WriteLine("Завершение программы...");
                    return;
                case 1:
                    myCounter.Increment();
                    break;
                case 2:
                    myCounter.Decrement();
                    break;
                case 3:
                    Console.WriteLine($"Значение счетчика: {myCounter.Value}");
                    break;
                default:
                    Console.WriteLine("Неправильный ввод");
                    break;
            }
        }
    }
}*/









//5 ZADANIE
/*using System;

namespace DeleteTask5
{
    class Delete
    {
        public int myInt;
        public string myString;

        public Delete(int value, string strings)
        {
            this.myInt = value;
            this.myString = strings;
        }
        public Delete() : this(0, "")
        {
        }

        public int myInt1
        {
            get { return myInt; }
            set { myInt = value; }
        }
        public string myString1
        {
            get { return myString; }
            set { myString = value; }
        }
        ~Delete()
        {
            Console.WriteLine($"Объект удален");
        }
    }
    class Task5
    {
        static void Main()
        {
            Delete obj1 = new Delete(10, "MyNameIsEgor");
            Console.WriteLine($"Объект №1 - {obj1.myInt}, {obj1.myString}");

            Delete obj2 = new Delete();
            obj1.myInt1 = 45;
            obj2.myString1 = "HiEgor";

            Console.WriteLine($"Объект №1 - {obj1.myInt}, {obj1.myString}");
            Console.WriteLine($"Объект №2 - {obj2.myInt}, {obj2.myString}");

            obj1 = null;
            GC.Collect();
            obj2 = null;
            GC.Collect();
        }
    }
}
*/