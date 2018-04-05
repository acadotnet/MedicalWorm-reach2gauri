using System;
using System.Collections.Generic;
using MedicalWorm.Core.Enums;
using MedicalWorm.Core.Interfaces;

namespace MedicalWorm.Core.Models
{
    public class Doctor : EmployeeBase, IEmployee
    {
        //TODO: Add constant for pay rate used in CalculatePay()

        public MedicalSpeciality Speciality { get; set; }
        public MedicalLicense LicenseObtained { get; set; }

        public List<Nurse> Nurses { get; set; }

        // TODO: Update logic here to just return the first Nurse that is an RN. if no RN, then just return the nurse with the least amount of hours worked
        public Nurse PrimaryNurse { get; set; }

        public Guid PrescriptionAuthorizationId { get; set; }

        public string PrintBadge()
        {
            return $"{Name}, {LicenseObtained.MedicalLicenseFormatted2()} ({EmployeeId})";
        }

        public decimal CalculatePay()
        {
            return HoursWorked * 180;
        }

        public override void TakeVacation(int numberOfDays)
        {
            VacationDays = VacationDays - (decimal)numberOfDays / 2;
        }

        public override decimal CalculateRemainingVacationDays()
        {
            if (VacationDays < 8)
            {
                VacationDays = 8;
            }

            return base.CalculateRemainingVacationDays();
        }
    }
}
