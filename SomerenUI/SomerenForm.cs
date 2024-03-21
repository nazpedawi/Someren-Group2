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
            DrinksPanel.Hide();
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

        private void ShowDrinksPanel()
        {

            DrinksPanel.Show();
            try
            {
                List<Drink> drinks = GetAllDrinks();
                DisplayDrinks(drinks);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public List<Drink> GetAllDrinks()
        {
            DrinkService drinkService = new DrinkService();
            List<Drink> drinks = drinkService.GetAll();
            return drinks;
        }

        public void DisplayDrinks(List<Drink> drinks)
        {
            ListViewDrinks.Items.Clear();

            foreach (Drink drink in drinks)
            {
                ListViewItem item = new ListViewItem(drink.Name);
                item.Tag = drink;
                item.SubItems.Add(drink.Type);
                item.SubItems.Add(drink.Price.ToString());
                item.SubItems.Add(drink.StockAmount.ToString());

                ListViewDrinks.Items.Add(item);
            }
        }
        private void toolStripRooms_Click(object sender, EventArgs e)
        {
            LecturersPanel.Hide();
            DrinksPanel.Hide();
            ShowRoomsPanel();
        }

        private void toolStripLecturers_Click(object sender, EventArgs e)
        {
            RoomsPanel.Hide();
            DrinksPanel.Hide();
            ShowLecturersPanel();
        }

        private void toolStripDrinks_Click(object sender, EventArgs e)
        {
            LecturersPanel.Hide();
            RoomsPanel.Hide();
            ShowDrinksPanel();
        }
    }
}