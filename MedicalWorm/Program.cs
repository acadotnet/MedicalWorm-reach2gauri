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

            //Nurses
            //find all the registered nurses
            var rns = nurses.Where(n => n.IsRegisteredNurse).ToList();

            //find all nurses who have letter 'A' in their name
            var aNurses = nurses.Where(n => n.Name.ToLower().Contains("a")).ToList();

            //find all nurses whose name starts with letter "b"
            var bNurses = nurses.Where(n => n.Name.ToLower().StartsWith("b")).ToList();

            //returns a bool true if we have atleast 1 registered nurses
            var hasRNS = nurses.Any(n => n.IsRegisteredNurse);

            //return a bool true if all of the nurses are registered
            var allRNS = nurses.All(n => n.IsRegisteredNurse);



            //Janitors
            //how many Janitors worked morethan 10 hours
            var jan1 = janitors.Where(j => j.HoursWorked > 10).Count();
            var jan2 = janitors.Count(j => j.HoursWorked > 10);

            //find the most hours worked by janitor
            var jan3 = janitors.Max(j => j.HoursWorked);

            //find the minimum hours  worked by janitor
            var jan4 = janitors.Min(j => j.HoursWorked);

            //find the total hours worked by all janitors
            var jan5 = janitors.Sum(j => j.HoursWorked);



            //Doctors
            //find doctor who have worked the most 
            //.OrderBy() is asc by default / .OrderByDescending()
            var doc1 = doctors.OrderByDescending(d => d.HoursWorked).Take(1).ToList();

            //find doctor who have worked the second most. we have to skip first record here.
            var doc2 = doctors.OrderByDescending(d => d.HoursWorked).ToList().Skip(1).Take(1);
            var doc3 = doctors.OrderByDescending(d => d.HoursWorked).Skip(1).Take(1).ToList();

            //list of doctors order by Name, speciality
            //.ThenBy() is asc by default / .ThenByDescending()
            var doc4 = doctors.OrderBy(d => d.Name).ThenBy(d => d.Speciality).ToList();

            //list of doctors order by Name, speciality, HoursWorked
            var doc5 = doctors.OrderBy(d => d.Name)
                              .ThenBy(d => d.Speciality)
                              .ThenByDescending(d => d.HoursWorked)
                              .ToList();

            //give me first doctor that matches the filter criteria
            //Last() works like first but give the last record who matches the criteria
            //first() would throw an exception if there are no matching record.
            var doc6 = doctors.Where(d => d.EmployeeId == 8082).First();
            var doc7 = doctors.First(d => d.EmployeeId == 8082);

            //firstOrDefault returns the default of type if no record find and save from exception
            //LastOrDefault() works like firstOrDefault but for last record
            var doc8 = doctors.Where(d => d.EmployeeId == 8082).FirstOrDefault();

            //
            var doc9 = doctors.Where(d => d.EmployeeId == 8082).Single();
            var doc10 = doctors.Where(d => d.EmployeeId == 8082).SingleOrDefault();

            //add a list of Nurses to a doctor 
            var doc11 = doctors.First();    //give the first instance of doctors list i.e. [0] index
            doc11.Nurses.AddRange(rns);

            


            Console.ReadLine();
        }
    }
}
    