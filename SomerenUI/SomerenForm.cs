using Microsoft.VisualBasic;
using SomerenDAL;
using SomerenModel;
using SomerenService;
namespace SomerenUI
{
    // the main form class
    public partial class SomerenForm : Form
    {
        private DrinkService drinkService;
        private StudentService studentService;
        public SomerenForm()
        {
            InitializeComponent();
            InitializePanels(); // Hide all panels initially
            drinkService = new DrinkService();
            studentService = new StudentService();
        }
        private void InitializePanels()
        {
            StudentsPanel.Hide();
            RoomsPanel.Hide();
            LecturersPanel.Hide();
            DrinksPanel.Hide();
            ActivitiesPanel.Hide();
        }

        // Method to hide all panels except the provided one for when the user clicks on one of the tool strip items
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
        // Method to display the lecturers panel and the listview with lecturers data inside
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

        // Method to display the rooms panel and the listview with rooms data inside
        private void ShowRoomsPanel()
        {
            RoomsPanel.Show();
            try
            {
                List<Room> rooms = GetAllRooms();
                DisplayRooms(rooms);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // Method to display the students panel and the listview with students data inside
        private void ShowStudentsPanel()
        {
            try
            {
                StudentsPanel.Show();
                List<Student> students = GetAllStudents();
                DisplayStudents(students);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // Method to display the drinks panel and the listview with drinks data inside
        private void ShowDrinksPanel()
        {
            try
            {
                DrinksPanel.Show();
                List<Drink> drinks = GetAllDrinks();
                DisplayDrinks(drinks);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ShowActivitiesPanel()
        {
            try
            {
                ActivitiesPanel.Show();
                List<Activity> activities = GetAllActivities();
                DisplayActivities(activities);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // methods to get the data from the database from services
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
        public List<Activity> GetAllActivities()
        {
            ActivityService activityService = new ActivityService();
            List<Activity> activities = activityService.GetAll();
            return activities;
        }
        // method to display lecturers data in the listview of lecturers
        public void DisplayLecturers(List<Lecturer> lecturers)
        {
            ListViewLecturers.Items.Clear(); // Clear existing items in ListView
                                             // to not get duplicate data each time the lecturers menu item is clicked

            foreach (Lecturer lecturer in lecturers)
            {
                ListViewItem item = new ListViewItem(lecturer.FirstName);
                item.Tag = lecturer;
                item.SubItems.Add(lecturer.LastName);
                item.SubItems.Add(lecturer.Age.ToString());
                item.SubItems.Add(lecturer.PhoneNumber.ToString());

                ListViewLecturers.Items.Add(item); // add all the data in columns to the listview
            }
        }
        // method to display students data in the listview of students
        public void DisplayStudents(List<Student> students)
        {
            ListViewStudents.Items.Clear(); // Clear existing items in ListView to not get duplicate data in the listview

            foreach (Student student in students)
            {
                ListViewItem item = new ListViewItem(student.StudentNumber.ToString());
                item.Tag = student;
                item.SubItems.Add(student.FirstName);
                item.SubItems.Add(student.LastName);
                item.SubItems.Add(student.Class.ToString());
                item.SubItems.Add(student.PhoneNumber.ToString());

                ListViewStudents.Items.Add(item); // add items to listview of students
            }
        }
        // method to display rooms data in the listview of rooms
        public void DisplayRooms(List<Room> rooms)
        {
            ListViewRooms.Items.Clear(); // clear existing data from the listview

            foreach (Room room in rooms)
            {
                ListViewItem item = new ListViewItem(room.RoomNumber.ToString());
                item.Tag = room;
                item.SubItems.Add(room.BuildingName);
                item.SubItems.Add(room.RoomType);
                item.SubItems.Add(room.NumberOfBeds.ToString());

                ListViewRooms.Items.Add(item); // add data to the listview
            }
        }

        // Method to display drinks in the ListView
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
                string stockStatus = GetStockStatus(drink.StockAmount); // calling the method to calculate the stock status based on the stock amount
                item.SubItems.Add(stockStatus);

                ListViewDrinks.Items.Add(item);
            }
        }
        public void DisplayActivities(List<Activity> activities)
        {
            ListViewActivities.Items.Clear();

            foreach (Activity activity in activities)
            {
                ListViewItem item = new ListViewItem(activity.ActivityName);
                item.Tag = activity;
                item.SubItems.Add(activity.StartDateTime.ToString("yyyy-MM-dd HH:mm"));
                item.SubItems.Add(activity.EndDateTime.ToString("yyyy-MM-dd HH:mm"));
                ListViewActivities.Items.Add(item);
            }
        }

        // method to calculate the stock status (empty, nearly depleted or sufficient) based on the stock amnount of the drink
        private string GetStockStatus(int stockAmount)
        {
            if (stockAmount < 1)
                return "Stock empty";
            else if (stockAmount < 10)
                return "Stock nearly depleted";
            else
                return "Stock sufficient";
        }

        // event handlers for each menu item in the toolstrip for when they are clicked
        private void toolStripStudents_Click(object sender, EventArgs e)
        {
            HidePanelsExcept(StudentsPanel);
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
        private void toolStripOrders_Click(object sender, EventArgs e)
        {
            OrdersForm ordersForm = new OrdersForm();
            ordersForm.ShowDialog();
        }
        private void toolStripRevenue_Click_1(object sender, EventArgs e)
        {
            RevenueForm revenueForm = new RevenueForm();
            revenueForm.ShowDialog();
        }

        // event handlers for adding, updating and deleting drinks
        // for when the buttons on the form are clicked
        private void AddDrinkbtn_Click(object sender, EventArgs e)
        {
            AddDrinksForm addDrinkForm = new AddDrinksForm();
            addDrinkForm.ShowDialog(); // show the form for adding a drink
        }
        private void DeleteDrinkbtn_Click(object sender, EventArgs e)
        {
            if (ListViewDrinks.SelectedItems.Count > 0) // make sure a drink is selected by the user
            {
                ListViewItem selectedItem = ListViewDrinks.SelectedItems[0];
                Drink drink = selectedItem.Tag as Drink;

                if (drink != null) // make sure the row selected has a drink in it
                {
                    try
                    {
                        drinkService.DeleteDrink(drink);
                        ListViewDrinks.Items.Remove(selectedItem); // remove the drink from the listview
                        MessageBox.Show("Drink deleted successfully."); // let the user know the drink was deleted
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

                        if (updateForm.ShowDialog() == DialogResult.OK) // maken sure dialog result is OK
                                                                        // and make sure the drink was updated successfully in the updateform
                        {
                            UpdateDrinkInformation(selectedItem, drink); // call method to change the selected drink details to the new details in the listview
                            drinkService.UpdateDrink(drink); // evem the stock status is updated based on the new stock amount
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

        // Method to update the information of a drink in the ListView
        private void UpdateDrinkInformation(ListViewItem selectedItem, Drink drink)
        {
            selectedItem.SubItems[0].Text = drink.Name; // update name
            selectedItem.SubItems[1].Text = drink.Type; // update type (alcoholic or non-alcoholic)
            selectedItem.SubItems[2].Text = drink.Price.ToString(); // update price
            selectedItem.SubItems[3].Text = drink.StockAmount.ToString(); // update stock
        }

        private void DeleteStudentbtn_Click(object sender, EventArgs e)
        {
            if (ListViewStudents.SelectedItems.Count > 0) // make sure a student is selected by the user
            {
                ListViewItem selectedItem = ListViewStudents.SelectedItems[0];
                Student student = selectedItem.Tag as Student;

                if (student != null) // make sure the row selected has a student in it
                {
                    // warn the user if they actually want to delete the selected student
                    DialogResult dialogResult = MessageBox.Show($"Are you sure you want to delete student '{student.FirstName} {student.LastName}' ?", "Confirmation", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes) // if the user clicks 'yes' on the message box then delete the student
                    {
                        try
                        {
                            studentService.DeleteStudent(student);
                            ListViewStudents.Items.Remove(selectedItem); // remove the student from the listview
                            MessageBox.Show("Student deleted successfully."); // let the user know the student was deleted
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a student first");
            }
        }
        private void AddStudentbtn_Click(object sender, EventArgs e)
        {
            AddStudentForm addStudentForm = new AddStudentForm();
            addStudentForm.ShowDialog();
        }
        private void UpdateStudentbtn_Click(object sender, EventArgs e)
        {
            if (ListViewStudents.SelectedItems.Count > 0) // make usre a student has been selected
            {
                try
                {
                    ListViewItem selectedItem = ListViewStudents.SelectedItems[0];
                    if (selectedItem.Tag is Student student)
                    {
                        UpdateStudentForm updateForm = new UpdateStudentForm(student);

                        if (updateForm.ShowDialog() == DialogResult.OK) // maken sure dialog result is OK
                                                                        // and make sure the student was updated successfully in the updateform
                        {
                            UpdateStudentInformation(selectedItem, student); // call method to change the selected student details to the new details in the listview
                            studentService.UpdateStudent(student); // update student details in the database
                            MessageBox.Show("Student updated successfully!");
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
                MessageBox.Show("Please select a student first.");
            }
        }

        // Method to update the information of a student in the ListView
        private void UpdateStudentInformation(ListViewItem selectedItem, Student student)
        {
            selectedItem.SubItems[0].Text = student.StudentNumber.ToString(); // update name
            selectedItem.SubItems[1].Text = student.FirstName; // update name
            selectedItem.SubItems[2].Text = student.LastName;
            selectedItem.SubItems[3].Text = student.Class;
            selectedItem.SubItems[4].Text = student.PhoneNumber.ToString();
        }

        private void toolStripActivity_Click(object sender, EventArgs e)
        {
            HidePanelsExcept(ActivitiesPanel);
            ShowActivitiesPanel();
        }
    }
}