using System;

namespace ReportGenerator
{
    internal class ReportGeneratorClient
    {
        private static void Main()
        {
            var db = new EmployeeDB();

            // Add some employees
            db.AddEmployee(new Employee("Anne", 3000));
            db.AddEmployee(new Employee("Berit", 2000));
            db.AddEmployee(new Employee("Christel", 1000));


            // Create a default (name-first) report
            var reportGenerator = new NameFirst();
            reportGenerator.CompileReport(db);

            Console.WriteLine("");
            Console.WriteLine("");

            // Create a salary-first report
            var reportGenerator2 = new SalaryFirst();
            reportGenerator2.CompileReport(db);
        }
    }
}