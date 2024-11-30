using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DoerList.MainForm;

namespace DoerList
{
    public partial class DailyDoerUI : Form
    {

        private List<TaskItem> dailyTasks;
        public event EventHandler TaskUpdated;

        public DailyDoerUI()
        {
            InitializeComponent();
            dailyTasks = new List<TaskItem>(); // Initialize an empty list if needed
        }

        // Existing constructor with parameters
        public DailyDoerUI(List<TaskItem> tasks)
        {
            InitializeComponent();
            dailyTasks = tasks;
        }

        private void NotifyMainForm()
        {
            int totalTasks = dailyTasks.Count;
            int completedTasks = dailyTasks.Count(t => t.IsCompleted);

            TaskUpdated?.Invoke(this, EventArgs.Empty); // Notify MainForm about updates
        }

        private void DailyDoerUI_Load(object sender, EventArgs e)
        {
            UpdateTaskList();
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            string newTask = Microsoft.VisualBasic.Interaction.InputBox(
                "Enter Task Details:", "Add Daily Task", "", -1, -1);

            if (!string.IsNullOrWhiteSpace(newTask))
            {
                DateTime dueDate = DateTime.Today.AddDays(1);
                dailyTasks.Add(new TaskItem(newTask, dueDate));
                UpdateTaskList();
           
            }
            else
            {
                MessageBox.Show("Task details cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRemoveTask_Click(object sender, EventArgs e)
        {
            if (listViewDailyTasks.SelectedItems.Count > 0)
            {
                foreach (ListViewItem selectedItem in listViewDailyTasks.SelectedItems)
                {
                    dailyTasks.RemoveAll(t => t.Name == selectedItem.Text);
                    listViewDailyTasks.Items.Remove(selectedItem);
                }
        
            }
            else
            {
                MessageBox.Show("Please select a task to remove.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void chkTaskCompleted_CheckedChanged(object sender, EventArgs e)
        {
            var checkBox = sender as CheckBox;
            if (checkBox != null && checkBox.Tag is TaskItem task)
            {
                task.IsCompleted = checkBox.Checked;
    
            }
        }

        private void UpdateTaskList()
        {
            listViewDailyTasks.Items.Clear();
            foreach (var task in dailyTasks)
            {
                ListViewItem item = new ListViewItem(task.Name);
                item.SubItems.Add(task.DueDate.ToShortDateString());
                listViewDailyTasks.Items.Add(item);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
            this.Close(); 
        }
    }
}
