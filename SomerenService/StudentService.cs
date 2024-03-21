using System;
using System.Collections.Generic;
using System.Linq;
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
}
