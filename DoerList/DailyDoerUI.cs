using static DoerList.MainForm;

namespace DoerList
{
    public partial class DailyDoerUI : Form
    {
        private string loggedInUsername;
        private List<TaskItem> dailyTasks;
        public event EventHandler TaskUpdated;
        public event Action<List<TaskItem>> DailyTasksUpdated;
        public event EventHandler DailyDoerEnabled;
        public event EventHandler DailyDoerDisabled;


        public DailyDoerUI(List<TaskItem> tasks, string username = "")
        {
            InitializeComponent();
            dailyTasks = tasks ?? new List<TaskItem>(); // Use passed-in tasks or initialize a new list
            loggedInUsername = username;
        }

        private void UpdateTaskList()
        {
            listViewDailyTasks.Items.Clear();
            foreach (var task in dailyTasks)
            {
                ListViewItem item = new ListViewItem(task.Name);
                item.SubItems.Add(task.DueDate.ToShortDateString());
                item.SubItems.Add(task.IsCompleted ? "Yes" : "No");
                listViewDailyTasks.Items.Add(item);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm(loggedInUsername);
            mainForm.ShowDialog();
            this.Hide();
        }

        private void chkDaily_CheckedChanged(object sender, EventArgs e)
        {
            var checkBox = sender as CheckBox;
            if (checkBox != null && checkBox.Tag is TaskItem task)
            {
                task.IsCompleted = checkBox.Checked;

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listViewDailyTasks.SelectedItems.Count > 0)
            {
                foreach (ListViewItem selectedItem in listViewDailyTasks.SelectedItems)
                {
                    string taskName = selectedItem.Text;
                    FileDatabaseHelper.RemoveTask(loggedInUsername, taskName);
                    dailyTasks.RemoveAll(t => t.Name == taskName);
                }

                UpdateTaskList();
            }
            else
            {
                MessageBox.Show("Please select a task to remove.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DailyDoerUI_Load(object sender, EventArgs e)
        {
            dailyTasks = FileDatabaseHelper.LoadTasks(loggedInUsername);
            UpdateTaskList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string newTask = Microsoft.VisualBasic.Interaction.InputBox("Enter Task Details:", "Add Daily Task", "", -1, -1);

            if (!string.IsNullOrWhiteSpace(newTask))
            {
                DateTime dueDate = DateTime.Today.AddDays(1);
                var task = new TaskItem(newTask, dueDate);
                dailyTasks.Add(task);

                FileDatabaseHelper.SaveTask(loggedInUsername, task);
                UpdateTaskList();
            }
            else
            {
                MessageBox.Show("Task details cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEnable_Click(object sender, EventArgs e)
        {
            DailyDoerEnabled?.Invoke(this, EventArgs.Empty); // Raise the enabled event
            MessageBox.Show("DailyDoer has been enabled.");
        }

        private void btnDisable_Click(object sender, EventArgs e)
        {
            DailyDoerDisabled?.Invoke(this, EventArgs.Empty); // Raise the disabled event
            MessageBox.Show("DailyDoer has been disabled.");
        }

    }
}
