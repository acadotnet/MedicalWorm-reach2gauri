using System;
using System.Collections.Generic;
using MedicalWorm.Core.Enums;
using MedicalWorm.Core.Interfaces;

namespace MedicalWorm.Core.Models
{
    public class Nurse : EmployeeBase, IEmployee
    {
        private const int _payRate = 150;

        public bool IsRegisteredNurse { get; set; }
        public List<NursingCertification> Certifications { get; set; }
        public IEnumerable<int> FloorsWorked { get; set; }

        public string PrintBadge()
        {
            //TODO: If IsRegisteredNurse, prepend RN- to every Certification
            if(IsRegisteredNurse)
            {
                var rnCertification = new List<string>();
                foreach (var c in Certifications)
                {
                    rnCertification.Add(string.Concat("RN_", c));
                    //rnCertification.ConvertAll<NursingCertification>(System.Converter(string,NursingCertification);
                }
            }
            var commaSeperatedFloors = string.Join(", ", FloorsWorked);
            var commaSeperated = string.Join(", ", Certifications);

            return $"{Name}, {commaSeperated}, {commaSeperatedFloors} ({EmployeeId})";
        }

        public decimal CalculatePay()
        {
            if(HoursWorked > 40.00M)
            {
                return (1.50M * (HoursWorked * _payRate));
            }
            return HoursWorked * _payRate;
        }

        public override void TakeVacation(int numberOfDays)
        {
            HoursWorked = HoursWorked - (decimal)numberOfDays / 2;
        }
    }
}
