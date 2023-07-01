//ZADANIE 1 
/*using System;
using System.Reflection;


namespace Worler1
{

    class Worker
    {
        public Worker(string n, string s, decimal r, int d)
        {
        this.name = n;
        this.surname = s;
        this.rate = r;
        this.days = d;        
        }
        public string name = "";                   
        public string surname = "";                
        public decimal rate;                   
        public int days;                   

        public int GetSalary()
        {
            return (int)rate * days;
        }

        public static void Main()
        {
            Worker worker = new Worker("Иван", "Иванов", 1000.0m, 20);

            Console.Write("Введите имя работника: ");
            worker.name = Console.ReadLine();

            Console.Write("Введите фамилию работника: ");
            worker.surname = Console.ReadLine();

            Console.Write("Введите ставку за день работы: ");
            worker.rate = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Введите количество отработанных дней: ");
            worker.days = Convert.ToInt32(Console.ReadLine());


            decimal salary = worker.GetSalary();
            Console.WriteLine("Зарплата работника {0} {1} составляет {2} рублей.", worker.name, worker.surname, salary); 
         }
    }
}*/






//2 ZADANIE
/*namespace WorkerTask2
{
    class Worker
    {
        public Worker(string n, string s, double r, int d)
        {
            this.name = n;
            this.surname = s;
            this.rate = r;
            this.days = d;
        }
        private string name = "";
        private string surname = "";
        private double rate;
        private int days;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public double Rate
        {
            get { return rate; }
            set { rate = value; }
        }

        public int Days
        {
            get { return days; }
            set { days = value; }
        }

        public double GetSalary()
        {
            double getSalary = Rate * Days;
            return getSalary;
        }
    }
    class Task2
    {
        static void Main()
        {
            Console.Write("Введите имя работника: ");
            string n = Console.ReadLine()!;
            Console.Write("Введите фамилию работника: ");
            string s = Console.ReadLine()!;
            Console.Write("Введите ставку работника: ");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите количество отработанных дней работника: ");
            int d = Convert.ToInt32(Console.ReadLine());

            Worker worker1 = new Worker(n, s, r, d);

            Console.Write($"Зарплата {n} {s} составляет {worker1.GetSalary()} рублей");
        }
    }
}*/






//3
/*namespace CalculationTask3
{
    class Calculation
    {
        public Calculation(string str)
        {
            this.calculationLine = str;
        }
        public string calculationLine = "";

        public void SetCalculationLine(string line)
        {
            calculationLine = line;
        }

        public void SetLastSymbolCalculationLine(char symbol)
        {
            calculationLine += symbol;
        }

        public string GetCalculationLine()
        {
            return calculationLine;
        }

        public char GetLastSymbol()
        {
            return calculationLine[calculationLine.Length - 1];
        }

        public void DeleteLastSymbol()
        {
            calculationLine = calculationLine.Substring(0, calculationLine.Length - 1);
        }
    }
    class Task3
    {
        static void Main()
        {

        }
    }
}*/