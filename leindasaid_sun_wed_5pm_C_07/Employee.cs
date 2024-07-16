using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leindasaid_sun_wed_5pm_C_07
{
    public enum Gender
    {
        M, // Male
        F  // Female
    }

    public enum SecurityLevel
    {
        Guest,
        Developer,
        Secretary,
        DBA
    }
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public SecurityLevel SecurityLevel { get; set; }
        public Gender Gender { get; set; }
        public HireDate HireDate { get; set; }
        public double Salary { get; set; }

        public Employee(int id, string name, SecurityLevel securityLevel, Gender gender, HireDate hireDate, double salary)
        {
            Id = id;
            Name = name;
            SecurityLevel = securityLevel;
            Gender = gender;
            HireDate = hireDate;
            Salary = salary;
        }
        public override string ToString()
        {
            return $"Id: {this.Id}, Name: {this.Name}, Security Level: {this.SecurityLevel}, Gender: {this.Gender}, Hire Date: {this .HireDate}, Salary: {this .Salary}";
        }
    }
}

