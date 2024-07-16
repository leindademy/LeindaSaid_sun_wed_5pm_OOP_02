using System.Reflection;

namespace leindasaid_sun_wed_5pm_C_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter employee id: ");
                int id;
                while (!int.TryParse(Console.ReadLine(), out id))
                {
                    Console.WriteLine("Invalid input. Please enter a valid employee id:");
                }

                Console.WriteLine("Enter employee name: ");
                string name = Console.ReadLine();

                Console.WriteLine("Enter employee security level (Guest, Developer, Secretary, DBA): ");
                SecurityLevel securityLevel;
                while (!Enum.TryParse(Console.ReadLine(), true, out securityLevel))
                {
                    Console.WriteLine("Invalid security level. Enter one of the following: Guest, Developer, Secretary, DBA");
                }

                Console.WriteLine("Enter employee gender (M/F): ");
                Gender gender;
                while (!Enum.TryParse(Console.ReadLine(), true, out gender) || (gender != Gender.M && gender != Gender.F))
                {
                    Console.WriteLine("Invalid input. Please enter 'M' for Male or 'F' for Female:");
                }

                Console.WriteLine("Enter employee hire date (Day, Month, Year): ");
                int day, month, year;
                while (!int.TryParse(Console.ReadLine(), out day))
                {
                    Console.WriteLine("Invalid day. Please enter a valid day:");
                }
                while (!int.TryParse(Console.ReadLine(), out month))
                {
                    Console.WriteLine("Invalid month. Please enter a valid month:");
                }
                while (!int.TryParse(Console.ReadLine(), out year))
                {
                    Console.WriteLine("Invalid year. Please enter a valid year:");
                }
                HireDate hireDate = new HireDate(day, month, year);

                Console.WriteLine("Enter employee salary: ");
                double salary;
                while (!double.TryParse(Console.ReadLine(), out salary))
                {
                    Console.WriteLine("Invalid input. Please enter a valid salary:");
                }

                employees[i] = new Employee(id, name, securityLevel, gender, hireDate, salary);
            }

            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
            }
        }
    }
}
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter employee id: ");
                int id;
                while (!int.TryParse(Console.ReadLine(), out id))
                {
                    Console.WriteLine("Invalid input. Please enter a valid employee id:");
                }

                Console.WriteLine("Enter employee name: ");
                string name = Console.ReadLine();

                Console.WriteLine("Enter employee security level (Guest, Developer, Secretary, DBA): ");
                SecurityLevel securityLevel;
                while (!Enum.TryParse(Console.ReadLine(), true, out securityLevel))
                {
                    Console.WriteLine("Invalid security level. Enter one of the following: Guest, Developer, Secretary, DBA");
                }

                Console.WriteLine("Enter employee gender (M/F): ");
                Gender gender;
                while (!Enum.TryParse(Console.ReadLine(), true, out gender) || (gender != Gender.M && gender != Gender.F))
                {
                    Console.WriteLine("Invalid input. Please enter 'M' for Male or 'F' for Female:");
                }

                Console.WriteLine("Enter employee hire date (Day, Month, Year): ");
                int day, month, year;
                while (!int.TryParse(Console.ReadLine(), out day))
                {
                    Console.WriteLine("Invalid day. Please enter a valid day:");
                }
                while (!int.TryParse(Console.ReadLine(), out month))
                {
                    Console.WriteLine("Invalid month. Please enter a valid month:");
                }
                while (!int.TryParse(Console.ReadLine(), out year))
                {
                    Console.WriteLine("Invalid year. Please enter a valid year:");
                }
                HireDate hireDate = new HireDate(day, month, year);

                Console.WriteLine("Enter employee salary: ");
                double salary;
                while (!double.TryParse(Console.ReadLine(), out salary))
                {
                    Console.WriteLine("Invalid input. Please enter a valid salary:");
                }

                employees[i] = new Employee(id, name, securityLevel, gender, hireDate, salary);
            }

            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
            }
        }
    }
}
