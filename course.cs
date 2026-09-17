public class Course
{
    public string Name { get; }
    public int Capacity { get; }
    // studenter som är anmälda
public List<Student> Students { get; } = new List<Student>();
    public Course(string name, int capacity)
    {
        Name = name;
        Capacity = capacity;
    }
// Lägger till en student
public bool AddStudent(Student student)
{
        if (Students.Contains(student))
        {
            return false;
        }
    if (Students.Count >= Capacity)
        {
            return false;
        }
        Students.Add(student);

        if (!student.Courses.Contains(this))
        {
            student.Courses.Add(this);
        }
        return true;
    }
    // tar bort en student
public bool RemoveStudent(Student student)
{
    if (!Students.Remove(student))
    {
        return false;
    }

    student.Courses.Remove(this);

    return true;
}



}