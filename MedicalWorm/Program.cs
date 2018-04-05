using System;
using System.Collections.Generic;
using System.Linq;
using MedicalWorm.Core.Enums;
using MedicalWorm.Core.Interfaces;
using MedicalWorm.Core.Models;

namespace MedicalWorm
{
    class Program
    {
        static void Main(string[] args)
        {
            var doctors = EmployeeFactory.GenerateDoctors();
            var nurses = EmployeeFactory.GenerateNurses();
            var janitors = EmployeeFactory.GenerateJanitors();

            Console.WriteLine("Welcome to Medical Worm Hospital");




            Console.ReadLine();
        }
    }
}
    