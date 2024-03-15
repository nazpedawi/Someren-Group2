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
            List<Room> rooms = GetAllRooms();
            DisplayLecturers(lecturers);
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
        private void ListViewLecturers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListViewRooms_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}