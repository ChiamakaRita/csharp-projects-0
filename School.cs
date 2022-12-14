using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharp_projects_0
{
    public class School
    {
         public List<string> Teachers { get; set; } = new List<string>();
        public string name;
        public School(string schoolName)
        {
            this.name = schoolName;
        }

        public void AddTeacher(string newTecherName)
        {
            Teachers.Add(newTecherName);
        }

        public void ListAllTeachers()
        {
            foreach(string teacher in Teachers)
            {
                Console.WriteLine(teacher);
            }
        }

        public int NumberOfTeachers()
        {
            return Teachers.Count;
        }

        public void TeachersNameWithLetterA()
        {
            foreach(string name in Teachers)
            {
                if(name.Contains('A', StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(name);
                }
            }
        }
    }
}
    
