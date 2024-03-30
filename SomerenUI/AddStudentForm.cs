using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SomerenModel;
using SomerenService;

namespace SomerenUI
{
    public partial class AddStudentForm : Form
    {
        StudentService studentService;
        public AddStudentForm()
        {
            studentService = new StudentService();
            InitializeComponent();
        }
        // event handler for when the add student button is clicked
        private void AddStudentbtn_Click(object sender, EventArgs e)
        {
            try
            {
                // check if the student number field is empty
                // and if the student number already exists for another student
                int studentNumber = int.Parse(StudentNumbertxtbox.Text);
                if (string.IsNullOrEmpty(studentNumber.ToString()))
                {
                    MessageBox.Show("Please enter a student number");
                    return;
                }
                if (studentService.StudentNumberExists(studentNumber))
                {
                    MessageBox.Show($"A Student already exists with student number '{studentNumber}', \n Please enter a different student number.");
                    return;
                }

                // to make sure both first name and last nbame are filled in
                string firstName = FirstNametxtbox.Text;
                string lastName = LastNametxtbox.Text;
                if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
                {
                    MessageBox.Show("Please enter both  the first and last name of student");
                    return;
                }

                // check to make sure a class for the student is selected
                string selectedClass = Classcombobox.SelectedItem?.ToString();
                if (string.IsNullOrEmpty(selectedClass.ToString()))
                {
                    MessageBox.Show("Please select a class for the student");
                    return;
                }

                // check if the phone number field is empty
                int PhoneNumber = int.Parse(PhoneNumbertxtbox.Text);
                if (string.IsNullOrEmpty(PhoneNumber.ToString()))
                {
                    MessageBox.Show("Please enter the phone number of student");
                    return;
                }

                // check to see if a room number has been selected
                int selectedRoom = int.Parse(RoomNumbercombobox.SelectedItem?.ToString());
                if (string.IsNullOrEmpty(selectedRoom.ToString()))
                {
                    MessageBox.Show("Please select a room number for the student");
                    return;
                }

                // create new student object with the details given by the user
                Student student = new Student(studentNumber, firstName, lastName, selectedClass, PhoneNumber, selectedRoom);
                studentService.AddStudent(student); // add the newly created student to the database

                MessageBox.Show($"Student '{firstName} {lastName}' added Successfully!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
