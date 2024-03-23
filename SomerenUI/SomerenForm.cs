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

        private void ShowStudentsPanel()
        {
            StudentsPanel.Show();
            List<Student> students = GetAllStudents();
            DisplayStudents(students);
        }

        private void ShowDrinksPanel()
        {
            DrinksPanel.Show();
            List<Drink> drinks = GetAllDrinks();
            DisplayDrinks(drinks);
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

                if (drink.StockAmount < 1)
                {
                    item.SubItems.Add("Stock empty");
                }
                else if (drink.StockAmount < 10)
                {
                    item.SubItems.Add("Stock nearly depleted");
                }
                else
                {
                    item.SubItems.Add("Stock sufficient");
                }

                ListViewDrinks.Items.Add(item);
            }
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
        public List<Room> GetAllRooms()
        {
            RoomService roomService = new RoomService();
            List<Room> rooms = roomService.GetAll();
            return rooms;
        }
        public List<Drink> GetAllDrinks()
        {
            DrinkService drinkService = new DrinkService();
            List<Drink> drinks = drinkService.GetAll();
            return drinks;
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
        private void toolStripStudents_Click(object sender, EventArgs e)
        {
            RoomsPanel.Hide();
            LecturersPanel.Hide();
            DrinksPanel.Hide();
            ShowStudentsPanel();
        }
        private void toolStripLecturers_Click(object sender, EventArgs e)
        {
            RoomsPanel.Hide();
            StudentsPanel.Hide();
            DrinksPanel.Hide();
            ShowLecturersPanel();
        }
        private void toolStripRooms_Click(object sender, EventArgs e)
        {
            StudentsPanel.Hide();
            LecturersPanel.Hide();
            DrinksPanel.Hide();
            ShowRoomsPanel();
        }
        private void toolStripDrinks_Click(object sender, EventArgs e)
        {
            StudentsPanel.Hide();
            LecturersPanel.Hide();
            RoomsPanel.Hide();
            ShowDrinksPanel();
        }

        private void AddDrinkbtn_Click(object sender, EventArgs e)
        {
            AddDrinksForm addDrinkForm = new AddDrinksForm();
            addDrinkForm.ShowDialog();
        }

        private void DeleteDrinkbtn_Click(object sender, EventArgs e)
        {
            DrinkService drinkService = new DrinkService();
            if (ListViewDrinks.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = ListViewDrinks.SelectedItems[0];
                Drink drink = selectedItem.Tag as Drink;

                if (drink != null)
                {
                    drinkService.DeleteDrink(drink);
                    ListViewDrinks.Items.Remove(selectedItem);
                    MessageBox.Show("Drink was deleted successfully.");
                }
            }
            else
            {
                MessageBox.Show("Please select a drink first");
            }
        }

        private void UpdateDrinkbtn_Click(object sender, EventArgs e)
        {
            DrinkService drinkService = new DrinkService();
            if (ListViewDrinks.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = ListViewDrinks.SelectedItems[0];
                Drink drink = selectedItem.Tag as Drink;


                UpdateDrinksForm updateForm = new UpdateDrinksForm(drink);
                if (updateForm.ShowDialog() == DialogResult.OK)
                {
                    selectedItem.SubItems[0].Text = drink.Name;
                    selectedItem.SubItems[1].Text = drink.Type;
                    selectedItem.SubItems[2].Text = drink.Price.ToString();
                    selectedItem.SubItems[3].Text = drink.StockAmount.ToString();

                    try
                    {
                        drinkService.UpdateDrink(drink);
                        MessageBox.Show("Drink updated successfully!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating drink: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a drink first.");
            }
        }

    }
}