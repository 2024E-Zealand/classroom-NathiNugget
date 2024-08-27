// See https://aka.ms/new-console-template for more information
using ClassRoomNet60;

ClassRoom cr = new ClassRoom();
cr.Name = "3B";
cr.SemesterStart = new DateTime(2024, 08, 26); 
cr.StudentList = new List<Student>();


Student s1 = new Student("Nathaniel", 07, 30);
cr.StudentList.Add(s1);
Student s2 = new Student("Isak", 10, 7);
cr.StudentList.Add(s2);
Student s3 = new Student("Abdi", 2, 15);
cr.StudentList.Add(s3);
Console.WriteLine(cr.Name);
Console.WriteLine(cr.SemesterStart);
Console.WriteLine($"Amount of students in class {cr.StudentList.Count}");
foreach (Student s in cr.StudentList)
{
    Console.WriteLine(string.Join(',', s.Name, s.BirthDay, s.BirthMonth, s.Season));
    
}
foreach (KeyValuePair<string, int> kvp in cr.BirthDaysBySeason())
{
    Console.WriteLine($"Amount of people with birthdays in: {kvp.Key} is {kvp.Value}");
}