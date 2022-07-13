using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32.TaskScheduler;
using System.IO;
using Task = Microsoft.Win32.TaskScheduler.Task;

namespace WallpaperGen
{
    public partial class AutoForm : Form
    {
        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        private static extern bool AllocConsole();
        private string[] PathArr;

        public AutoForm()
        {
            InitializeComponent();
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    PathArr = Directory.GetFiles(fbd.SelectedPath);

                    selectLabel.Text = PathArr.Length.ToString() + " Wallpapers found.";
                }
            }
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            removeTask();

            string paths = "";
            foreach (string path in PathArr)
            {
                paths = paths + path + " ";
            }

            using (TaskService ts = new TaskService())
            {
                TaskDefinition td = ts.NewTask();
                td.RegistrationInfo.Description = "Changes wallpaper periodically";

                td.Triggers.Add(new DailyTrigger { DaysInterval = 1 });

                string exePath = Path.GetFullPath("../../../../../WallpaperSwitcher/WallpaperSwitcher/bin/Debug/net6.0-windows/WallpaperSwitcher.exe");

                td.Actions.Add(new ExecAction(exePath, paths, null));

                ts.RootFolder.RegisterTaskDefinition(@"WallpaperSwitcher", td);
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            removeTask();
        }


        private void removeTask()
        {
            using (TaskService ts = new TaskService())
            {
                TaskCollection tc = ts.RootFolder.GetTasks();
                foreach (Task task in tc)
                {
                    if (task.Name == "WallpaperSwitcher")
                    {
                        ts.RootFolder.DeleteTask("WallpaperSwitcher");
                    }
                }
            }
        }
    }
}
