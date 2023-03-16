using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosePrinciple.Common.Model
{
    public class JuniorDevSalaryCalculator : BaseSalaryCalculator
    {
        public JuniorDevSalaryCalculator(DeveloperReport report) : base(report)
        {

        }
        public override double CalculateSalary()
        {
            return _developerReport.HourlyRate * _developerReport.WorkingHours;
        }
    }
}
