using csharp_exercise_enum.Entities.Enums;

namespace csharp_exercise_enum.Entities
{
    public class Worker
    {
        public string Name {  get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker() { }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void addContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void removeContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double income(int year, int month )
        {
            double sum = BaseSalary;
            foreach (var item in Contracts)
            {
                if (item.Date.Year == year && item.Date.Month == month)
                {
                    sum += item.totalValue();
                }
            }

            return sum;
        }
    }
}
