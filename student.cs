public class Student
{
    public string Name { get; }

    // Kurser som studenten har
    public List<Course> Courses { get; } = new List<Course>();

    public Student(string name)
    {
        Name = name;
    }

    public bool Join(Course course)
    {
        return course.Enroll(this);
    }
    public bool Leave (Course course)
    {
        return course.Remove(this);
    }
}