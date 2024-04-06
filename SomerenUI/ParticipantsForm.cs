using SomerenModel;
using SomerenService;
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
    public partial class ParticipantsForm : Form
    {

        public Activity activity;
        private StudentService studentService;
        public ParticipantsForm(Activity activity)
        {
            this.activity = activity;
            studentService = new StudentService();
            InitializeComponent();
            ShowParticipationPanel();
        }
        public List<Student> GetAllParticipants()
        {
            StudentService studentService = new StudentService();
            List<Student> participants = studentService.GetAllParticipants(activity);
            return participants;
        }

        public List<Student> GetAllNotParticipants()
        {
            StudentService studentService = new StudentService();
            List<Student> notparticipants = studentService.GetAllNotParticipants(activity);
            return notparticipants;
        }
        public void DisplayParticipants(List<Student> participants)
        {
            ListViewParticipants.Items.Clear();

            foreach (Student participant in participants)
            {
                ListViewItem item = new ListViewItem(participant.FirstName);
                item.Tag = participant;
                item.SubItems.Add(participant.LastName);
                item.SubItems.Add(participant.Class.ToString());
                item.SubItems.Add(participant.PhoneNumber.ToString());
                item.SubItems.Add(participant.RoomNumber.ToString());


                ListViewParticipants.Items.Add(item); // add all the data in columns to the listview
            }
        }

        public void DisplayNotParticipants(List<Student> notparticipants)
        {
            ListViewNonParticipants.Items.Clear();

            foreach (Student notparticipant in notparticipants)
            {
                ListViewItem item = new ListViewItem(notparticipant.FirstName);
                item.Tag = notparticipant;
                item.SubItems.Add(notparticipant.LastName);
                item.SubItems.Add(notparticipant.Class.ToString());
                item.SubItems.Add(notparticipant.PhoneNumber.ToString());
                item.SubItems.Add(notparticipant.RoomNumber.ToString());

                ListViewNonParticipants.Items.Add(item);
            }
        }
        private void ShowParticipationPanel()
        {
            ParticipationPanel.Show();
            try
            {
                List<Student> participants = GetAllParticipants();
                List<Student> notparticipants = GetAllNotParticipants();
                DisplayParticipants(participants);
                DisplayNotParticipants(notparticipants);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddParticipantsbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ListViewNonParticipants.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Please select a non participant first.");
                    return;
                }
                ListViewItem selectedItem = ListViewNonParticipants.SelectedItems[0];
                Student selectedStudents = selectedItem.Tag as Student;

                studentService.AddParticipant(selectedStudents, activity);
                MessageBox.Show("Participant added successfully!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteParticipantbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ListViewParticipants.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Please select a participant first.");
                    return;
                }
                ListViewItem selectedItem = ListViewParticipants.SelectedItems[0];
                Student selectedParticipants = selectedItem.Tag as Student;

                DialogResult result = MessageBox.Show("Are you sure you wish to remove this participant?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    studentService.DeleteParticipant(selectedParticipants, activity);

                    MessageBox.Show("Participant deleted successfully!");
                    Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddParticipantbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ListViewNonParticipants.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Please select a non participant first.");
                    return;
                }
                ListViewItem selectedItem = ListViewNonParticipants.SelectedItems[0];
                Student selectedStudents = selectedItem.Tag as Student;

                studentService.AddParticipant(selectedStudents, activity);
                MessageBox.Show("Participant added successfully!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
