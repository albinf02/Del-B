public class Student
{
    public string Name { get; }

    // Kurser som studenten har
    public List<Course> Courses { get; } = new List<Course>();

    public Student(string name)
    {
        Name = name;
    }

    public bool AddCourse(Course course)
    {
        if (Courses.Contains(course))
        {
            return false;
        }

        if (course.Students.Count >= course.Capacity)
        {
            return false;
        }

        Courses.Add(course);

        if (!course.Students.Contains(this))
        {
            course.Students.Add(this);
        }

        return true;
    }
}