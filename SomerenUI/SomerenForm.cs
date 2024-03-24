using SomerenDAL;
using SomerenModel;
using SomerenService;
namespace SomerenUI
{
    public partial class SomerenForm : Form
    {
        private DrinkService drinkService;
        public SomerenForm()
        {
            InitializeComponent();
            InitializePanels();
            drinkService = new DrinkService();
        }
        private void InitializePanels()
        {
            StudentsPanel.Hide();
            RoomsPanel.Hide();
            LecturersPanel.Hide();
            DrinksPanel.Hide();
        }
        private void HidePanelsExcept(Panel panelToShow)
        {
            foreach (Control control in Controls)
            {
                if (control is Panel panel)
                {
                    if (panel != panelToShow)
                    {
                        panel.Hide();
                    }
                }
            }
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
                string stockStatus = GetStockStatus(drink.StockAmount);
                item.SubItems.Add(stockStatus);

                ListViewDrinks.Items.Add(item);
            }
        }
        private string GetStockStatus(int stockAmount)
        {
            if (stockAmount < 1)
                return "Stock empty";
            else if (stockAmount < 10)
                return "Stock nearly depleted";
            else
                return "Stock sufficient";
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
            HidePanelsExcept(DrinksPanel);
            ShowStudentsPanel();
        }
        private void toolStripLecturers_Click(object sender, EventArgs e)
        {
            HidePanelsExcept(LecturersPanel);
            ShowLecturersPanel();
        }
        private void toolStripRooms_Click(object sender, EventArgs e)
        {
            HidePanelsExcept(RoomsPanel);
            ShowRoomsPanel();
        }
        private void toolStripDrinks_Click(object sender, EventArgs e)
        {
            HidePanelsExcept(DrinksPanel);
            ShowDrinksPanel();
        }

        private void AddDrinkbtn_Click(object sender, EventArgs e)
        {
            AddDrinksForm addDrinkForm = new AddDrinksForm();
            addDrinkForm.ShowDialog();
        }

        private void DeleteDrinkbtn_Click(object sender, EventArgs e)
        {
            if (ListViewDrinks.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = ListViewDrinks.SelectedItems[0];
                Drink drink = selectedItem.Tag as Drink;

                if (drink != null)
                {
                    try
                    {
                        drinkService.DeleteDrink(drink);
                        ListViewDrinks.Items.Remove(selectedItem);
                        MessageBox.Show("Drink deleted successfully.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a drink first");
            }
        }
        private void UpdateDrinkbtn_Click(object sender, EventArgs e)
        {
            if (ListViewDrinks.SelectedItems.Count > 0)
            {
                try
                {
                    ListViewItem selectedItem = ListViewDrinks.SelectedItems[0];
                    if (selectedItem.Tag is Drink drink)
                    {
                        UpdateDrinksForm updateForm = new UpdateDrinksForm(drink);

                        if (updateForm.ShowDialog() == DialogResult.OK)
                        {
                            UpdateDrinkInformation(selectedItem, drink);
                            drinkService.UpdateDrink(drink);
                            MessageBox.Show("Drink updated successfully!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a drink first.");
            }
        }
        private void UpdateDrinkInformation(ListViewItem selectedItem, Drink drink)
        {
            selectedItem.SubItems[0].Text = drink.Name;
            selectedItem.SubItems[1].Text = drink.Type;
            selectedItem.SubItems[2].Text = drink.Price.ToString();
            selectedItem.SubItems[3].Text = drink.StockAmount.ToString();
        }
    }
}