using SomerenModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomerenUI
{
    public partial class UpdateStudentForm : Form
    {
        private Student selectedStudent;

        // Constructor for initializing the form with the student selected by the user
        public UpdateStudentForm(Student student)
        {
            InitializeComponent();
            selectedStudent = student;
            InitializeForm();
        }

        // Method to initialize and fill the form with the details of the selected student
        private void InitializeForm()
        {
            try
            {
                // Fill the text boxes with the information of the selected student
                StudentNumbertxtbox.Text = selectedStudent.StudentNumber.ToString();
                FirstNametxtbox.Text = selectedStudent.FirstName;
                LastNametxtbox.Text = selectedStudent.LastName;
                PhoneNumbertxtbox.Text = selectedStudent.PhoneNumber.ToString();

                /* set the selected item in the class and room comboboxes
                based on the class and room number of the selected student */
                string selectedClass = selectedStudent.Class;
                if (Classcombobox.Items.Contains(selectedClass))
                {
                    Classcombobox.SelectedItem = selectedClass;
                }

                int selectedRoom = selectedStudent.RoomNumber;
                if (RoomNumbercombobox.Items.Contains(selectedRoom.ToString()))
                {
                    RoomNumbercombobox.SelectedItem = selectedRoom.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while initializing the form", ex.Message);
            }
        }
        private void UpdateStudentbtn_Click(object sender, EventArgs e)
        {
            if (ValidateInput()) // check if all fields are formatted correctly and are not empty
            {
                try
                {
                    // update the student details with the new information entered by the user
                    selectedStudent.StudentNumber = int.Parse(StudentNumbertxtbox.Text);
                    selectedStudent.FirstName = FirstNametxtbox.Text;
                    selectedStudent.LastName = LastNametxtbox.Text;
                    selectedStudent.Class = Classcombobox.SelectedItem?.ToString();
                    selectedStudent.RoomNumber = int.Parse(RoomNumbercombobox.SelectedItem?.ToString());
                    selectedStudent.PhoneNumber = int.Parse(PhoneNumbertxtbox.Text);

                    DialogResult = DialogResult.OK;  // Set dialog result to OK
                    Close(); // close the update student form
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while updating the student details: " + ex.Message);
                }
            }
        }
        private bool ValidateInput()
        {
            if (!int.TryParse(StudentNumbertxtbox.Text, out int studentNumber))
            {
                MessageBox.Show("Please enter a valid integer number for student number");
                return false;
            }
            if (!int.TryParse(PhoneNumbertxtbox.Text, out int phoneNumber))
            {
                MessageBox.Show("Please enter a valid 9-digit integer number for phone number");
                return false;
            }
            if (string.IsNullOrWhiteSpace(StudentNumbertxtbox.Text) ||
                string.IsNullOrWhiteSpace(FirstNametxtbox.Text) ||
                string.IsNullOrWhiteSpace(LastNametxtbox.Text) ||
                Classcombobox.SelectedItem == null ||
                RoomNumbercombobox.SelectedItem == null ||
                string.IsNullOrWhiteSpace(PhoneNumbertxtbox.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return false;
            }
            return true;
        }
    }
}
