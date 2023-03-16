using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosePrinciple.Common.Model
{
    public abstract class BaseSalaryCalculator
    {
        protected DeveloperReport _developerReport { get;set;}

        public BaseSalaryCalculator(DeveloperReport developerReport)
        {
            _developerReport = developerReport;
        }

        public abstract double CalculateSalary();
    }
}
