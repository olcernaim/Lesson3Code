using OpenClosePrinciple.Common.Model;
using System;
using System.Collections.Generic;

namespace OpenClosePrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BaseSalaryCalculator> devReports = new List<BaseSalaryCalculator>
            {
                new SeniorDevSalaryCalculator(new DeveloperReport{Id = 1, Name = "Dev1", Level = "Senior Developer", HourlyRate = 30.5, WorkingHours = 160}),
                new JuniorDevSalaryCalculator(new DeveloperReport{Id = 2, Name = "Dev2", Level = "Junior Developer", HourlyRate = 20, WorkingHours = 150}),
                new SeniorDevSalaryCalculator(new DeveloperReport{Id = 3, Name = "Dev3", Level = "Senior Developer", HourlyRate = 30.5, WorkingHours = 180}),
                new MidJuniorDevSalaryCalculator(new DeveloperReport{Id = 4, Name = "Dev4", Level = "Mid Junior Developer", HourlyRate = 30, WorkingHours = 180})
            };

            SalaryCalculator calculate = new SalaryCalculator(devReports);

            double totalSalary = calculate.CalculateTotalSalaries();

            Console.WriteLine("Sum of all developers salary is :" + totalSalary);

            // Senior ve Junior Developer maaş hesabı için farklı bir hesaplamaya ihtiyacmız var.
            // Senior developerlar maaş üzerinden %20 ikramiye almalı
        }
    }
}
