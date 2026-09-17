public class Course
{
    public string Name { get; }
    public int Capacity { get; }
    // studenter som är anmälda
public List<Student> Students {get;} = new List<Student<Student>();
    public Course(string name, int capacity)
    {
        Name = name;
        Capacity = capacity;
    }
}