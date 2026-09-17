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
bool removed = english.RemoveStudent(Albin);

Console.WriteLine($"Albin removed: {removed}");

Console.WriteLine("Students in the Course:");

foreach (Student student in english.Students)
{
    Console.WriteLine(student.Name);
}
bool removedTomas = english.RemoveStudent(Tomas);

Console.WriteLine($"Tomas removed: {removedTomas}");
