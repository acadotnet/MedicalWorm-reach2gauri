﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace MedicalWorm.Core.Enums
{
    //TODO: Add extension method for NursingCertification, see notes in Nurse.PrintBadge()

    public static class EnumExtensions
    {
        public static List<string> RegisteredCertificates()
        {
            
        }

        public static string MedicalLicenseFormatted2(this MedicalLicense license, bool isUpperCase = true, bool usePeriods = true)
        {       
            var abbrev = string.Empty;
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
            }

            return isUpperCase
                ? abbrev.ToUpper()
                : abbrev.ToLower();
        }
    }
}
