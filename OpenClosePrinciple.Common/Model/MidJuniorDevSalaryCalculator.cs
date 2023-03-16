using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosePrinciple.Common.Model
{
    public class MidJuniorDevSalaryCalculator : BaseSalaryCalculator
    {
        public MidJuniorDevSalaryCalculator(DeveloperReport report) : base(report)
        {

        }
        public override double CalculateSalary()
        {
            return _developerReport.HourlyRate * _developerReport.WorkingHours * 1.1;
        }
    }
}
