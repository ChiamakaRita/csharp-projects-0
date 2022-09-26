using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharp_projects_0
{
    public class Student
    {
        private int _id;
        private string _Name;
        private int _passMark = 35;

        public int Passmark
        {  
            get
            {
              return this._passMark;
            }
        }
        public string Name
        {
            set
            {
            if(string.IsNullOrEmpty(value))
            {
               throw new Exception ("Student name cannot be null or empty");
            }this._Name = value;
            }
            get
            {
               return string.IsNullOrEmpty(this._Name) ? "No name" : this._Name;
            }
        }
       
        public int Id
        {
              set
        {
            if(value <= 0)
            {
                throw new Exception("Student ID cannot be negative");
            }this._id = value;
        }
        get
        {
            return this._id;
        }
        }
    }
}