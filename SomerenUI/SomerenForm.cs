using SomerenDAL;
using SomerenModel;
using SomerenService;
namespace SomerenUI
{
    public partial class SomerenForm : Form
    {
        public SomerenForm()
        {
            InitializeComponent();
            StudentsPanel.Hide();
            RoomsPanel.Hide();
            LecturersPanel.Hide();
        }

        private void ShowLecturersPanel()
        {

            LecturersPanel.Show();
            try
            {
                List<Lecturer> lecturers = GetAllLecturers();
                DisplayLecturers(lecturers);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ShowRoomsPanel()
        {
            RoomsPanel.Show();
            List<Room> rooms = GetAllRooms();
            DisplayRooms(rooms);
        }

        private void ShoWStudentsPanel()
        {
            StudentsPanel.Show();
            List<Student> students = GetAllStudents();
            DisplayStudents(students);
        }
        public List<Lecturer> GetAllLecturers()
        {
            LecturerService lecturerService = new LecturerService();
            List<Lecturer> lecturers = lecturerService.GetAll();
            return lecturers;
        }

        public List<Student> GetAllStudents()
        {
            StudentService studentService = new StudentService();
            List<Student> students = studentService.GetAll();
            return students;
        }
        public void DisplayLecturers(List<Lecturer> lecturers)
        {
            ListViewLecturers.Items.Clear();

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
        public void DisplayStudents(List<Student> students)
        {
            ListViewStudents.Items.Clear();

            foreach (Student student in students)
            {
                ListViewItem item = new ListViewItem(student.StudentNumber.ToString());
                item.Tag = student;
                item.SubItems.Add(student.FirstName);
                item.SubItems.Add(student.LastName);
                item.SubItems.Add(student.Class.ToString());
                item.SubItems.Add(student.PhoneNumber.ToString());

                ListViewStudents.Items.Add(item);
            }
        }
        public List<Room> GetAllRooms()
        {
            RoomService roomService = new RoomService();
            List<Room> rooms = roomService.GetAll();
            return rooms;
        }

        public void DisplayRooms(List<Room> rooms)
        {
            ListViewRooms.Items.Clear();

            foreach (Room room in rooms)
            {
                ListViewItem item = new ListViewItem(room.RoomNumber.ToString());
                item.Tag = room;
                item.SubItems.Add(room.BuildingName);
                item.SubItems.Add(room.RoomType);
                item.SubItems.Add(room.NumberOfBeds.ToString());

                ListViewRooms.Items.Add(item);
            }
        }


        private void toolStripRooms_Click(object sender, EventArgs e)
        {
            StudentsPanel.Hide();
            LecturersPanel.Hide();
            ShowRoomsPanel();
        }

        private void toolStripLecturers_Click(object sender, EventArgs e)
        {
            RoomsPanel.Hide();
            StudentsPanel.Hide();
            ShowLecturersPanel();
        }

        private void toolStripDrinks_Click(object sender, EventArgs e)
        {
            DrinksForm drinksForm = new DrinksForm();
            drinksForm.ShowDialog();
        }

        private void toolStripStudents_Click(object sender, EventArgs e)
        {
            RoomsPanel.Hide();
            LecturersPanel.Hide();
            ShoWStudentsPanel();
        }

        private void SomerenForm_Load(object sender, EventArgs e)
        {

        }
    }
}