using System;
using System.Windows.Forms;

namespace DoerList
{
    public partial class AddTaskForm : Form
    {
        public string TaskName { get; private set; }
        public DateTime DueDate { get; private set; }
        public TimeSpan DueTime { get; private set; }

        public AddTaskForm()
        {
            InitializeComponent();
        }

        private void AddTaskForm_Load(object sender, EventArgs e)
        {
            
            datePickerDueDate.Value = DateTime.Now.Date;
            timePickerDueTime.Value = DateTime.Now; 
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtTaskName.Text))
            {
                MessageBox.Show("Task name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Set properties
            TaskName = txtTaskName.Text.Trim();
            DueDate = datePickerDueDate.Value;
            DueTime = timePickerDueTime.Value.TimeOfDay;

            DialogResult = DialogResult.OK; // Indicate successful input
            Close();
        }
    

        private void btnCancel_Click(object sender, EventArgs e)
        {
          
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}

