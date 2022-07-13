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
    public class Scheduler
    {
        public List<Wallpaper> WallpaperList { get; set; } = new List<Wallpaper>();

        public void RemoveTask()
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

        public void ScheduleTask()
        {
            if (WallpaperList.Count < 1) { return; }

            string paths = "";
            foreach (Wallpaper wp in WallpaperList)
            {
                paths = paths + wp.Path + " ";
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
    }
}
