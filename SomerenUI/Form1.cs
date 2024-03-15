using SomerenDAL;
using SomerenModel;
using SomerenService;
namespace SomerenUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<Lecturer> lecturers = GetAllLecturers();
            DisplayLecturers(lecturers);

        }
        public List<Lecturer> GetAllLecturers()
        {
            LecturerService lecturerService = new LecturerService();
            List<Lecturer> lecturers = lecturerService.GetAll();
            return lecturers;
        }

        public void DisplayLecturers(List<Lecturer> lecturers)
        {


            foreach (Lecturer lecturer in lecturers)
            {
                ListViewItem item = new ListViewItem(lecturer.FirstName);
                item.Tag = lecturer;
                item.SubItems.Add(lecturer.LastName);
                item.SubItems.Add(lecturer.Age.ToString());
                item.SubItems.Add(lecturer.PhoneNumber.ToString());

                ListViewLecturers.Items.Add(item);
            }
        }

        private void ListViewLecturers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}