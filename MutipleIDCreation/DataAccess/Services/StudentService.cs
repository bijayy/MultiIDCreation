using DataAccess.Models;

namespace DataAccess.Services;

public class StudentService
{
    public StudentService()
    {

    }

    public void AddStudent(int index)
    {
        using (var db = new MyDbContext())
        {
            var newEntity = new Student { Name = "Test #" + index, Description = "This is a test entity #" + index };
            db.Students.Add(newEntity);
            db.SaveChanges();
        }
    }

    public List<Student> GetStudents()
    {
        using (var db = new MyDbContext())
        {
           return db.Students.ToList();
        }
    }
}
