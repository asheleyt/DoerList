
using Tulpep.NotificationWindow;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;


namespace DoerList
{
    public partial class MainForm : Form
    {
        private List<TaskItem> tasks = new List<TaskItem>();
        private PopupNotifier notification;
        private string loggedInUsername;
        private string taskFilePath = "tasks.txt";
        public MainForm(String username)
        {
            InitializeComponent();

            loggedInUsername = username;
            UpdateTaskSummary();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBoxNewTask_TextChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            notification = new PopupNotifier
            {
                TitleText = "Task Manager",
                Delay = 5000
            };

            LoadTasksFromFile();
            UpdateTaskList();
            UpdateProgressBar();
            HighlightTaskDates();
            StartTaskReminderTimer();
        }

        private void StartTaskReminderTimer()
        {
            System.Windows.Forms.Timer taskReminderTimer = new System.Windows.Forms.Timer
            {
                Interval = 60000 
            };
            taskReminderTimer.Tick += TaskReminderTimer_Tick;
            taskReminderTimer.Start();
        }
        private void TaskReminderTimer_Tick(object sender, EventArgs e)
        {
            foreach (var task in tasks)
            {
                if (!task.IsCompleted)
                {
                    if (task.DueDate.Date == DateTime.Today.AddDays(1))
                    {
                        ShowNotification($"Task '{task.Name}' is due tomorrow!", NotificationType.Warning);
                    }
                    else if (task.DueDate.Date == DateTime.Today && task.DueDate.Hour == DateTime.Now.Hour)
                    {
                        ShowNotification($"Task '{task.Name}' is due soon at {task.DueDate.ToShortTimeString()}!", NotificationType.Info);
                    }
                    else if (task.DueDate.Date < DateTime.Today)
                    {
                        ShowNotification($"Task '{task.Name}' is overdue!", NotificationType.Error);
                    }
                }
            }
        }


        private void btnMainToDaily_Click(object sender, EventArgs e)
        {
            DailyDoerUI dailyTaskForm = new DailyDoerUI(tasks);
            dailyTaskForm.TaskUpdated += (s, args) =>
            {
                SaveTasksToFile();
                UpdateTaskList();
                UpdateProgressBar();
                HighlightTaskDates();
            };
            dailyTaskForm.ShowDialog();
        }

        private void UpdateTaskList()
        {
            listViewTask.Items.Clear();
            foreach (var task in tasks)
            {
                if (!task.IsCompleted)
                {
                    ListViewItem item = new ListViewItem(task.Name);
                    item.SubItems.Add(task.DueDate.ToShortDateString());
                    item.SubItems.Add(task.DueTime.ToString(@"hh\:mm")); 
                    listViewTask.Items.Add(item);
                }
            }
        }
        private void UpdateProgressBar()
        {
            int totalTasks = tasks.Count;
            int completedTasks = tasks.Count(t => t.IsCompleted);

            progressBar.Value = totalTasks > 0 ? (completedTasks * 100) / totalTasks : 0;
            lblCompletedTasks.Text = $"Progress: {progressBar.Value}%";
        }
        private void UpdatePendingTasks()
        {
            int pendingTasks = tasks.Count(t => !t.IsCompleted);
            lblPendingTasks.Text = $"Pending Tasks: {pendingTasks}";
        }
        private void HighlightTaskDates()
        {
            monthCalendar.RemoveAllBoldedDates();
            foreach (var task in tasks)
            {
                if (!task.IsCompleted)
                {
                    monthCalendar.AddBoldedDate(task.DueDate);
                }
            }
            monthCalendar.UpdateBoldedDates();
        }

        private void btnAddTaskMain_Click(object sender, EventArgs e)
        {
            string newTask = Microsoft.VisualBasic.Interaction.InputBox(
        "Enter Task Details:", "Add Task", "", -1, -1);

            if (!string.IsNullOrWhiteSpace(newTask))
            {
                string dateInput = Microsoft.VisualBasic.Interaction.InputBox(
                    "Enter Due Date (YYYY-MM-DD):", "Add Task", DateTime.Today.ToString("yyyy-MM-dd"), -1, -1);

         
                string timeInput = Microsoft.VisualBasic.Interaction.InputBox(
                    "Enter Due Time (HH:mm):", "Add Task", DateTime.Now.ToString("HH:mm"), -1, -1);

                if (DateTime.TryParse(dateInput, out DateTime dueDate) && TimeSpan.TryParse(timeInput, out TimeSpan dueTime))
                {
                    tasks.Add(new TaskItem(newTask, dueDate, dueTime));
                    SaveTasksToFile();
                    UpdateTaskList();
                    HighlightTaskDates();

                    ShowNotification($"Task '{newTask}' has been added successfully.", NotificationType.Success);
                }
                else
                {
                    ShowNotification("Invalid date or time format. Task not added.", NotificationType.Error);
                }
            }
            else
            {
                ShowNotification("Task details cannot be empty.", NotificationType.Warning);
            }
        }

        private void btnRemoveTaskMain_Click(object sender, EventArgs e)
        {
            if (listViewTask.SelectedItems.Count > 0)
            {
                foreach (ListViewItem selectedItem in listViewTask.SelectedItems)
                {
                    tasks.RemoveAll(t => t.Name == selectedItem.Text);
                    listViewTask.Items.Remove(selectedItem);
                }
                SaveTasksToFile();
                ShowNotification("Selected task(s) removed successfully!", NotificationType.Success);
                UpdateProgressBar();
            }
            else
            {
                ShowNotification("Please select a task to remove!", NotificationType.Warning);
            }
        }

        private void btnClearAllMain_Click(object sender, EventArgs e)
        {
            if (tasks.Count > 0)
            {
                DialogResult confirmResult = MessageBox.Show(
                    "Are you sure you want to clear all tasks?",
                    "Confirm Clear All",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    tasks.Clear();
                    SaveTasksToFile();
                    UpdateTaskList();
                    UpdateProgressBar();
                    ShowNotification("All tasks cleared successfully!", NotificationType.Success);
                }
            }
            else
            {
                ShowNotification("No tasks to clear!", NotificationType.Info);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {//btnSearch
            string searchTerm = Microsoft.VisualBasic.Interaction.InputBox(
                "Enter search term:", "Search Task", "", -1, -1);

            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                foreach (ListViewItem item in listViewTask.Items)
                {
                    item.Selected = item.Text.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0;
                }

                int selectedCount = listViewTask.SelectedItems.Count;
                if (selectedCount > 0)
                {
                    ShowNotification($"Found {selectedCount} matching task(s).", NotificationType.Info);
                }
                else
                {
                    ShowNotification($"No tasks found matching \"{searchTerm}\".", NotificationType.Info);
                }
            }
            else
            {
                ShowNotification("Search term cannot be empty!", NotificationType.Warning);
            }

        }

        private void ShowNotification(string message, NotificationType type)
        {
            notification.TitleText = "Task Manager";
            notification.ContentText = message;

            switch (type)
            {
                case NotificationType.Success:
                    notification.BodyColor = Color.LightGreen;
                    break;
                case NotificationType.Warning:
                    notification.BodyColor = Color.Orange;
                    break;
                case NotificationType.Error:
                    notification.BodyColor = Color.Red;
                    break;
                case NotificationType.Info:
                    notification.BodyColor = Color.LightBlue;
                    break;
            }

            notification.Delay = 5000;
            notification.Popup();
        }

        private void SaveTasksToFile()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(taskFilePath))
                {
                    foreach (var task in tasks)
                    {
                        string line = $"{task.Name}|{task.DueDate}|{task.IsCompleted}";
                        writer.WriteLine(line);
                    }
                }
            }
            catch (Exception ex)
            {
                ShowNotification($"Error saving tasks: {ex.Message}", NotificationType.Error);
            }
        }
        private void LoadTasksFromFile()
        {
            try
            {
                if (File.Exists(taskFilePath))
                {
                    using (StreamReader reader = new StreamReader(taskFilePath))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            string[] parts = line.Split('|');
                            if (parts.Length == 3)
                            {
                                string name = parts[0];
                                DateTime dueDate = DateTime.Parse(parts[1]);
                                bool isCompleted = bool.Parse(parts[2]);

                                tasks.Add(new TaskItem(name, dueDate, isCompleted));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ShowNotification($"Error loading tasks: {ex.Message}", NotificationType.Error);
            }
        }

        public enum NotificationType
        {
            Success,
            Warning,
            Error,
            Info
        }
        public class TaskItem
        {
            public string Name { get; set; }
            public DateTime DueDate { get; set; }
            public TimeSpan DueTime { get; set; } 
            public bool IsCompleted { get; set; }

            public TaskItem(string name, DateTime dueDate, bool isCompleted = false)
            {
                Name = name;
                DueDate = dueDate;
                DueTime = dueTime;
                IsCompleted = isCompleted;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DailyDoerUI dailyDoerUI = new DailyDoerUI(tasks);
            dailyDoerUI.ShowDialog();
            this.Hide();
        }
        private void DisplayDailySummary()
        {
            int pendingTasks = tasks.Count(t => !t.IsCompleted && t.DueDate.Date == DateTime.Today);
            int completedTasks = tasks.Count(t => t.IsCompleted && t.DueDate.Date == DateTime.Today);

            ShowNotification($"Today's Summary:\nPending Tasks: {pendingTasks}\nCompleted Tasks: {completedTasks}", NotificationType.Info);
        }

        private void MarkAsCompleted_Click(object sender, EventArgs e)
        {
            if (listViewTask.SelectedItems.Count > 0)
            {
                foreach (ListViewItem selectedItem in listViewTask.SelectedItems)
                {
                    var task = tasks.FirstOrDefault(t => t.Name == selectedItem.Text);
                    if (task != null)
                    {
                        task.IsCompleted = true;
                    }
                }
                SaveTasksToFile();
                UpdateTaskList();
                UpdateProgressBar();
                UpdatePendingTasks();
                ShowNotification("Selected task(s) marked as completed!", NotificationType.Success);
            }
            else
            {
                ShowNotification("Please select a task to mark as completed!", NotificationType.Warning);
            }
        }

        private void UpdateTaskSummary()
        {
  
            int totalTasks = tasks.Count;
            int completedTasks = tasks.Count(t => t.IsCompleted);
            int pendingTasks = totalTasks - completedTasks;

            
            lblTotalTasks.Text = $"Total Tasks: {totalTasks}";
            lblCompletedTasks.Text = $"Completed Tasks: {completedTasks}";
            lblPendingTasks.Text = $"Pending Tasks: {pendingTasks}";
        }

       


    }
}
