using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DoerList.MainForm;

namespace DoerList
{
    public static class FileDatabaseHelper
    {
        private static string usersFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "users.txt");
        private static string tasksFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "tasks.txt");

        public static void Initialize()
        {
            if (!File.Exists(usersFile))
                File.Create(usersFile).Close();

            if (!File.Exists(tasksFile))
                File.Create(tasksFile).Close();
        }

        public static bool RegisterUser(string username, string password)
        {
            foreach (var line in File.ReadLines(usersFile))
            {
                var parts = line.Split('|');
                if (parts[0] == username)
                    return false;
            }

            File.AppendAllText(usersFile, $"{username}|{password}{Environment.NewLine}");
            return true;
        }

        public static bool ValidateUser(string username, string password)
        {
            foreach (var line in File.ReadLines(usersFile))
            {
                var parts = line.Split('|');
                if (parts[0] == username && parts[1] == password)
                    return true;
            }
            return false;
        }

        public static List<TaskItem> LoadTasks(string username)
        {
            var tasks = new List<TaskItem>();

            foreach (var line in File.ReadLines(tasksFile))
            {
                var parts = line.Split('|');
                if (parts[0] == username)
                {
                    string taskName = parts[1];
                    DateTime dueDate = DateTime.Parse(parts[2]);
                    bool isCompleted = bool.Parse(parts[3]);
                    tasks.Add(new TaskItem(taskName, dueDate, isCompleted));
                }
            }

            return tasks;
        }

        public static void SaveTask(string username, TaskItem task)
        {
            File.AppendAllText(tasksFile, $"{username}|{task.Name}|{task.DueDate:yyyy-MM-dd}|{task.IsCompleted}{Environment.NewLine}");
        }

        public static void RemoveTask(string username, string taskName)
        {
            var lines = new List<string>(File.ReadAllLines(tasksFile));
            lines.RemoveAll(line =>
            {
                var parts = line.Split('|');
                return parts[0] == username && parts[1] == taskName;
            });

            File.WriteAllLines(tasksFile, lines);
        }
    }

}
