using csharp_projects_0;

School school = new("Grace Group of Schools");

school.AddTeacher("Nneoma");
school.AddTeacher("Henry");

school.ListAllTeachers();

int numOfTeachers = school.NumberOfTeachers();

Console.WriteLine($"There are {numOfTeachers} teachers in this school");
