using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SomerenModel;
using SomerenService;


namespace SomerenUI
{
    public partial class SupervisorsForm : Form
    {
        public Activity activity;
        private LecturerService lecturerService;

        public SupervisorsForm(Activity activity)
        {
            this.activity = activity;
            lecturerService = new LecturerService();
            InitializeComponent();
            ShowSupervisationPanel();
        }

        public List<Lecturer> GetAllSupervisors()
        {
            LecturerService lecturerService = new LecturerService();
            List<Lecturer> supervisors = lecturerService.GetAllSupervisors(activity);
            return supervisors;
        }

        public List<Lecturer> GetAllNotSupervisors()
        {
            LecturerService lecturerService = new LecturerService();
            List<Lecturer> notsupervisors = lecturerService.GetAllNotSupervisors(activity);
            return notsupervisors;
        }
        public void DisplaySupervisors(List<Lecturer> supervisors)
        {
            ListViewSupervisors.Items.Clear();

            foreach (Lecturer supervisor in supervisors)
            {
                ListViewItem item = new ListViewItem(supervisor.FirstName);
                item.Tag = supervisor;
                item.SubItems.Add(supervisor.LastName);
                item.SubItems.Add(supervisor.Age.ToString());
                item.SubItems.Add(supervisor.PhoneNumber.ToString());

                ListViewSupervisors.Items.Add(item); // add all the data in columns to the listview
            }
        }

        public void DisplayNotSupervisors(List<Lecturer> notsupervisors)
        {
            ListViewNonSupervisors.Items.Clear();

            foreach (Lecturer notsupervisor in notsupervisors)
            {
                ListViewItem item = new ListViewItem(notsupervisor.FirstName);
                item.Tag = notsupervisor;
                item.SubItems.Add(notsupervisor.LastName);
                item.SubItems.Add(notsupervisor.Age.ToString());
                item.SubItems.Add(notsupervisor.PhoneNumber.ToString());

                ListViewNonSupervisors.Items.Add(item);
            }
        }
        private void ShowSupervisationPanel()
        {
            SupervisationPanel.Show();
            try
            {
                List<Lecturer> supervisors = GetAllSupervisors();
                List<Lecturer> notsupervisors = GetAllNotSupervisors();
                DisplaySupervisors(supervisors);
                DisplayNotSupervisors(notsupervisors);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddSupervisorbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ListViewNonSupervisors.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Please select a non supervisor first.");
                }
                ListViewItem selectedItem = ListViewNonSupervisors.SelectedItems[0];
                Lecturer  selectedLecturer = selectedItem.Tag as Lecturer;  
                
                lecturerService.AddSupervisor(selectedLecturer, activity);
            }
            catch (Exception ex){
                MessageBox.Show(ex.Message);
            }
        }
    }
}
