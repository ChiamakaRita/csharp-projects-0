using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharp_projects_0
{
    public class Program
    {
        public static void Main(string[] args)
        {

           School school = new("Grace Group of Schools");

           school.AddTeacher("Nneoma");
           school.AddTeacher("Henry");

           school.ListAllTeachers();

           school.TeachersNameWithLetterA();
           Calculations calculations = new Calculations();
           Calculations.EvenNumbers(10);
           int sum = calculations.AddNumber(10, 20);
           Console.WriteLine("sum = {0}", sum);
        //    calling a static meth
           calculations.Module();
           


        //    int numOfTeachers = school.NumberOfTeachers();

        //    Console.WriteLine($"There are {numOfTeachers} teachers in this school");
        }
    }
}

