
public class Student
{
    public string Name {get; }
    
    //kurser som som studenten har
   public List<Course> Courses { get; } = new List<Course>();



    public Student(string name)

    {
        Name = name;
    }
}