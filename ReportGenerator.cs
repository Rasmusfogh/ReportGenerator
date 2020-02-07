using System;
using System.Collections.Generic;

namespace ReportGenerator
{


    abstract class ReportGenerator
    {
        public abstract void CompileReport(EmployeeDB e);

        protected List<Employee> GenerateList(EmployeeDB _employeeDb)
        {
            var employees = new List<Employee>();
            Employee employee;

            _employeeDb.Reset();

            // Get all employees
            while ((employee = _employeeDb.GetNextEmployee()) != null)
                employees.Add(employee);

            return employees;
        }
    }

    class NameFirst : ReportGenerator
    {
        public override void CompileReport(EmployeeDB em)
        {
            var employees = base.GenerateList(em);

            foreach (var e in employees)
            {
                Console.WriteLine("Name-first report");
                Console.WriteLine("------------------");
                Console.WriteLine("Name: {0}", e.Name);
                Console.WriteLine("Salary: {0}", e.Salary);
                Console.WriteLine("------------------");
            }
        }
    }

    class SalaryFirst : ReportGenerator
    {
        public override void CompileReport(EmployeeDB em)
        {
            var employees = base.GenerateList(em);

            Console.WriteLine("Salary-first report");

            foreach (var e in employees)
            {
                Console.WriteLine("------------------");
                Console.WriteLine("Salary: {0}", e.Salary);
                Console.WriteLine("Name: {0}", e.Name);
                Console.WriteLine("------------------");
            }

        }
    }
}
