using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalWorm.Core.Enums
{
    //TODO: Add extension method for NursingCertification, see notes in Nurse.PrintBadge()

    public static class EnumExtensions
    {
        public static string MedicalLicenseFormatted2(this MedicalLicense license, bool isUpperCase = true, bool usePeriods = true)
        {       
            var abbrev = "";
            switch (license)
            {
                case MedicalLicense.DoctorofMedicine:
                    abbrev = usePeriods 
                        ? "M.D." 
                        : "MD";
                    break;

                case MedicalLicense.DoctorofOsteopathicMedicine:
                    abbrev = usePeriods
                        ? "D.O."
                        : "DO";
                    break;

                default:
                    abbrev = "";
                    break;
            }

            return isUpperCase
                ? abbrev.ToUpper()
                : abbrev.ToLower();
        }
    }
}
