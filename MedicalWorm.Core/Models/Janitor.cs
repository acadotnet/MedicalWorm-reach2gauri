using System;
using MedicalWorm.Core.Interfaces;

namespace MedicalWorm.Core.Models
{
    public class Janitor : IEmployee
    {
        public string ExternalAgencyId { get; set; }

        public string ExternalAgencyName { get; set; }

        public string Name { get; set; }

        public decimal HoursWorked { get; set; }

        public string PrintBadge()
        {
            //TODO: Print a temporary badge with name and agency name

            throw new NotImplementedException();
        }

        public decimal CalculatePay()
        {
            //TODO: Calculate pay using minimum wage
            //TODO: Store current minimum wage in app.config, pull value from there

            throw new NotImplementedException();
        }
    }
}
