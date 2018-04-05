using System.Collections.Generic;
using MedicalWorm.Core.Enums;
using MedicalWorm.Core.Interfaces;

namespace MedicalWorm.Core.Models
{
    public class Nurse : EmployeeBase, IEmployee
    {
        //TODO: Add constant for pay rate used in CalculatePay()

        public bool IsRegisteredNurse { get; set; }
        public List<NursingCertification> Certifications { get; set; }
        public IEnumerable<int> FloorsWorked { get; set; }

        public string PrintBadge()
        {
            //TODO: If IsRegisteredNurse, prepend RN- to every Certification
            //TODO: Include comma seperated list of floors in badge
            var commaSeperated = string.Join(", ", Certifications);

            return $"{Name}, {commaSeperated} ({EmployeeId})";
        }

        public decimal CalculatePay()
        {
            //TODO: Nurse should be paid "time and a half" for anything over 40hrs

            return HoursWorked * 150;
        }

        public override void TakeVacation(int numberOfDays)
        {
            HoursWorked = HoursWorked - (decimal)numberOfDays / 2;
        }
    }
}
