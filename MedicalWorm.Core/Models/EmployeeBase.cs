using System;

namespace MedicalWorm.Core.Models
{
    public abstract class EmployeeBase
    {
        public int EmployeeId { get; set; }

        public string Name { get; set; }

        public decimal HoursWorked { get; set; }

        public decimal VacationDays { get; set; }

        // Any class that extends this base class must implement this method. 
        // Notice we have no method body.
        public abstract void TakeVacation(int numberOfDays);

        // Any class that extends this base class can change the behavior but is not required to
        public virtual decimal CalculateRemainingVacationDays()
        {
            return HoursWorked;
        }
    }
}
