namespace Csharp4
{
    public class Employee
    {
        public string Name { get; set; }
        public string Position { get; set; }
        private double _salary;

        public double Salary
        {
            get { return _salary; }
            set
            {
                if (value >= 0)
                    _salary = value;
                else
                    throw new ArgumentException("Salary cannot be negative");
            }
        }

        public Employee(string name, string position, double salary)
        {
            Name = name;
            Position = position;
            Salary = salary;
        }

        public void IncreaseSalary(double amount)
        {
            Salary += amount;
        }

        public void DecreaseSalary(double amount)
        {
            if (Salary - amount >= 0)
                Salary -= amount;
            else
                throw new ArgumentException("Salary cannot be negative");
        }

        public static bool operator ==(Employee emp1, Employee emp2)
        {
            return emp1.Salary == emp2.Salary;
        }

        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return !(emp1 == emp2);
        }

        public static bool operator <(Employee emp1, Employee emp2)
        {
            return emp1.Salary < emp2.Salary;
        }

        public static bool operator >(Employee emp1, Employee emp2)
        {
            return emp1.Salary > emp2.Salary;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("John", "Manager", 5000);
            Employee employee2 = new Employee("Alice", "Developer", 4000);

            Console.WriteLine(employee1.Name + "'s salary: " + employee1.Salary);
            Console.WriteLine(employee2.Name + "'s salary: " + employee2.Salary);

            employee1.IncreaseSalary(1000);
            employee2.DecreaseSalary(500);

            Console.WriteLine(employee1.Name + "'s salary: " + employee1.Salary);
            Console.WriteLine(employee2.Name + "'s salary: " + employee2.Salary);

            Console.WriteLine("Are salaries equal? " + (employee1 == employee2));
            Console.WriteLine("Is salary of employee1 greater than salary of employee2? " + (employee1 > employee2));
            Console.WriteLine("Is salary of employee1 not equal to salary of employee2? " + (employee1 != employee2));
        }
    }
}
