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

        //    school.AddTeacher("Nneoma");
        //    school.AddTeacher("Henry");

        //    school.ListAllTeachers();

           school.TeachersNameWithLetterA();
           Calculations calculations = new Calculations(5);
           float Area = calculations.CalArea();
           Console.WriteLine("Area = {0}", Area);

            Calculations calculations2 = new Calculations(10);
           float Area2 = calculations2.CalArea();
           Console.WriteLine("Area2 = {0}", Area2);

           Calculations.EvenNumbers(10);
           int sum = calculations.AddNumber(10, 20);
           Console.WriteLine("sum = {0}", sum);
           calculations.Module();
           

           


        //    int numOfTeachers = school.NumberOfTeachers();

        //    Console.WriteLine($"There are {numOfTeachers} teachers in this school");
        }
    }
}

