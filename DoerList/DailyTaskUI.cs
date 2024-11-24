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
    public partial class DailyTaskUI : Form
    {
        private List<string> dailyTasks = new List<string>(); // List to store daily tasks

        public DailyTaskUI()
        {
            InitializeComponent();
            LoadDailyTasks();
        }

        private void LoadDailyTasks()
        {
            foreach (var task in dailyTasks)
            {
                if (!listBoxTasks.Items.Contains(task))
                {
                    listBoxTasks.Items.Add(task);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTask.Text))
            {
                if (chkDaily.Checked)
                {
                    if (!dailyTasks.Contains(txtTask.Text))
                    {
                        dailyTasks.Add(txtTask.Text); // Add to daily tasks list
                        MessageBox.Show("Task added to daily tasks.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    listBoxTasks.Items.Add(txtTask.Text); // Add to normal list
                }

                txtTask.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a task.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedItem != null)
            {
                listBoxTasks.Items.Remove(listBoxTasks.SelectedItem);
            }
            else
            {
                MessageBox.Show("Please select a task to delete.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            listBoxTasks.Items.Clear();
        }

        private void btnReloadDailyTasks_Click(object sender, EventArgs e)
        {
            LoadDailyTasks();
        }
    }
}
