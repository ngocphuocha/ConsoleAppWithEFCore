using GalaxyConsole.Database;
namespace GalaxyConsole;

public class Program
{
    static void Main(string[] args)
    {
        Student std = new Student() { Name = "Superman" };

        StudentRepository studentRepos = new StudentRepository(new GalaxyConsoleContext());

        studentRepos.AddStudent(std);
    }
}

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
}

public class StudentRepository : IStudentRepository
{
    private readonly GalaxyConsoleContext _context;
    public StudentRepository(GalaxyConsoleContext context)
    {
        _context = context;
    }

    public void AddStudent(Student student)
    {
        _context.Students.Add(student);
        _context.SaveChanges();

        Console.WriteLine("Add new student success with Id {0} and name: {1}",
        student.Id, student.Name);
    }
}

public interface IStudentRepository
{
    void AddStudent(Student student);
}