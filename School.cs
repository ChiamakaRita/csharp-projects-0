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
    }
}