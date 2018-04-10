using System;
using System.Configuration;
using MedicalWorm.Core.Interfaces;

namespace MedicalWorm.Core.Models
{
    public class Janitor : IEmployee
    {
        public string ExternalAgencyId { get; set; }

        public string ExternalAgencyName { get; set; }

        public string Name { get; set; }

        public decimal HoursWorked { get; set; }

        private decimal _minimumWage = Convert.ToDecimal(ConfigurationManager.AppSettings["MinimumWage"]);

        public string PrintBadge()
        {
            return $"{Name}{ExternalAgencyName}";
        }

        public decimal CalculatePay()
        {
            return HoursWorked * _minimumWage;
        }
    }
}
