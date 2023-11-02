using csharp_exercise_enum.Entities;
using csharp_exercise_enum.Entities.Enums;

namespace csharp_exercise_enum
{
    class Program
    {
        static void Main(string[] agrs)
        {
            Console.WriteLine("Enter department's name");
            string depName = Console.ReadLine();
            Console.WriteLine("Enter worker name:");
            Console.WriteLine("Name");
            string name = Console.ReadLine();
            Console.WriteLine("Level (JUNIOR/MIDLEVEL/SENIOR)");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.WriteLine("Base Salary");
            double baseSalary = double.Parse(Console.ReadLine());

            Department department = new Department(depName);
            Worker worker = new Worker(name, level, baseSalary, department);

            Console.WriteLine("How many contracts to this worker?");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter #{i+1} contract data:");
                Console.WriteLine("Data DD/MM/YYYY");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Value per hour");
                double valuePerHour = double.Parse(Console.ReadLine());
                Console.WriteLine("Duration, (hours):");
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.addContract(contract);
            }

            Console.WriteLine();
            Console.WriteLine("Enter month and year to calculate income (MM/YYYY): ");
            string[] v = Console.ReadLine().Split("/");
            int month = int.Parse(v[0]);
            int year = int.Parse(v[1]);
            Console.WriteLine("Name " + worker.Name);
            Console.WriteLine("Deparment " + worker.Department.Name);
            Console.WriteLine("Income " + month + "/" + year + ": " + worker.income(month, year)); ;
        }
    }
}