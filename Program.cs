Course english = new Course("English", 2);

Student Albin = new Student ("Albin");
Student Filip = new Student ("Filip");

Albin.AddCourse(english);
Albin.AddCourse(english);
english.AddStudent(Filip);
Console.WriteLine("Students in the Course: ");

foreach (Student student in english.Students)
{
    Console.WriteLine(student.Name);
}