using OpenClosePrinciple.Common.Model;
using System.Collections.Generic;

namespace OpenClosePrinciple
{
    public class SalaryCalculator
    {
        private readonly IEnumerable<BaseSalaryCalculator> _developerCalculation;

        public SalaryCalculator(IEnumerable<BaseSalaryCalculator> developerCalculation)
        {
            _developerCalculation = developerCalculation;
        }

        public double CalculateTotalSalaries()
        {
            double totalSalaries = 0;

            foreach (var item in _developerCalculation)
            {
                totalSalaries += item.CalculateSalary();
            }

            return totalSalaries;
        }
        //private readonly IEnumerable<DeveloperReport> _developerReports;

        //public SalaryCalculator(IEnumerable<DeveloperReport> developerReports)
        //{
        //    _developerReports = developerReports;
        //}

        //public double CalculateTotal()
        //{
        //    double totalSalaries = 0;

        //    foreach (var item in _developerReports)
        //    {
        //        if (item.Level == "Senior Developer")
        //        {
        //            totalSalaries += item.HourlyRate * item.WorkingHours *1.2;
        //        }
        //        else
        //        {
        //            totalSalaries += item.HourlyRate * item.WorkingHours;
        //        }
        //    }

        //    return totalSalaries;
        //}
    }
}
