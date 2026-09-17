Course english = new Course("English", 2);

Student Albin = new Student ("Albin");
Student Filip = new Student ("Filip");

Albin.AddCourse(english);
english.AddStudent(Filip);
Student Tomas = new Student("Tomas");
bool added = english.AddStudent(Tomas);

Console.WriteLine($"Tomas added: {added}");

Console.WriteLine("Students in the Course: ");

foreach (Student student in english.Students)
{
    Console.WriteLine(student.Name);
}