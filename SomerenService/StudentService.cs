using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using SomerenDAL;
using SomerenModel;

namespace SomerenService;
public class StudentService
{
    private StudentDAO studentDAO;
    public StudentService()
    {
        studentDAO = new StudentDAO();
    }
    public List<Student> GetAll()
    {
        return studentDAO.GetAll(); 
    }
    public void DeleteStudent(Student student)
    {
        studentDAO.DeleteStudent(student);
    }
    public void AddStudent(Student student)
    {
        studentDAO.AddStudent(student);
    }
    public bool StudentNumberExists(int studentNumber)
    {
        return studentDAO.StudentNumberExists(studentNumber);
    }
    public void UpdateStudent (Student student)
    {
        studentDAO.UpdateStudent(student);
    }
    public List<Student> GetAllParticipants(Activity activity)
    {
        return studentDAO.GetAllParticipants(activity);
    }

    public List<Student> GetAllNotParticipants(Activity activity)
    {
        return studentDAO.GetAllNotParticipants(activity);
    }

    public void AddParticipant(Student student, Activity activity)
    {
        studentDAO.AddParticipant(student, activity);
    }

    public void DeleteParticipant(Student student, Activity activity)
    {
        studentDAO.DeleteParticipant(student, activity);
    }
}