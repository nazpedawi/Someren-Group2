using SomerenDAL;
using SomerenDAL;
using SomerenModel;
using SomerenService;

namespace ConsoleApp1
{
    internal class Program
    {
            static void Main(string[] args)
            {
                Program program = new Program();
                program.Start();
            }
            void Start()
            {

                LecturerService lecturerService = new LecturerService();
            List<Lecturer> lecturers = lecturerService.GetAll();

            foreach (Lecturer cust in lecturers)
            {
                Console.WriteLine(cust);
            }

        }
    }
}