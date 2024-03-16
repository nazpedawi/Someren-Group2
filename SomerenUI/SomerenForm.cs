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
            LecturersPanel.Hide();
            RoomsPanel.Hide();
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
                MessageBox.Show("An Error Occured While Loading Lecturers :" + ex.Message);
            }
        }

        private void ShowRoomsPanel()
        {
            RoomsPanel.Show();
            List<Room> rooms = GetAllRooms();
            DisplayRooms(rooms);
        }
        public List<Lecturer> GetAllLecturers()
        {
            LecturerService lecturerService = new LecturerService();
            List<Lecturer> lecturers = lecturerService.GetAll();
            return lecturers;
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
            LecturersPanel.Hide();
            ShowRoomsPanel();
        }

        private void toolStripLecturers_Click(object sender, EventArgs e)
        {
            RoomsPanel.Hide();
            ShowLecturersPanel();
        }
    }
}