public class Course
{
    public string Name { get; }
    public int MaxSeats { get; }

    // Studenter som är anmälda
    public List<Student> Students { get; } = new List<Student>();

    public Course(string name, int maxSeats)
    {
        Name = name;
        MaxSeats = maxSeats;
    }

    // Lägger till en student
    public bool Enroll(Student student)
    {
        if (Students.Contains(student))
        {
            return false;
        }

        if (Students.Count >= MaxSeats)
        {
            Console.WriteLine("Kursen är full");

            return false;
        }

        Students.Add(student);

        if (!student.Courses.Contains(this))
        {
            student.Courses.Add(this);
        }

        return true;
    }

    // Tar bort en student
    public bool Remove(Student student)
    {
        if (!Students.Remove(student))
        {
            return false;
        }

        student.Courses.Remove(this);

        return true;
    }
    public override string ToString()
    {
        return $"{Name} ({Students.Count}/{MaxSeats} platser)";
    }

    public void RollCall()
    {
        Console.WriteLine($"Närvaro i {Name}:");

        foreach (Student student in Students)
        {
            Console.WriteLine(student);
        }
    }


}