using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoerList
{
    public partial class AddTaskForm : Form
    {
        public string TaskName { get; private set; }
        public DateTime DueDate { get; private set; }
        public AddTaskForm()
        {
            InitializeComponent();
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTaskName.Text))
            {
                MessageBox.Show("Task name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            TaskName = txtTaskName.Text.Trim();
            DueDate = datePickerDueDate.Value;

            DialogResult = DialogResult.OK; 
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel; 
            Close();
        }

        private void AddTaskForm_Load(object sender, EventArgs e)
        {

        }
    }
}
