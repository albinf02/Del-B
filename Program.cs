Course english = new Course("English", 2);

Student Albin = new Student("Albin");
Student Filip = new Student("Filip");

bool firstRegistration = Albin.Join(english);
bool secondRegistration = Albin.Join(english);

Console.WriteLine($"First registration: {firstRegistration}");
Console.WriteLine($"Second registration: {secondRegistration}");

english.Enroll(Filip);

Student Tomas = new Student("Tomas");

bool added = english.Enroll(Tomas);

Console.WriteLine($"Tomas added: {added}");
Console.WriteLine("Students in the Course: ");


foreach (Student student in english.Students)
{
    Console.WriteLine(student.Name);
}
bool removed = english.Remove(Albin);

Console.WriteLine($"Albin removed: {removed}");
Console.WriteLine("Courses for Albin:");


foreach (Course course in Albin.Courses)
{
    Console.WriteLine(course.Name);
}
Console.WriteLine("Students in the Course:");

foreach (Student student in english.Students)
{
    Console.WriteLine(student.Name);
}
bool removedTomas = english.Remove(Tomas);
Console.WriteLine($"Tomas removed: {removedTomas}");

Filip.Schedule();
Console.WriteLine(english);