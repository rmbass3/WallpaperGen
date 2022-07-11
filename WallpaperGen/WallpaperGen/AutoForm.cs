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

namespace WallpaperGen
{
    public partial class AutoForm : Form
    {
        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        private static extern bool AllocConsole();
        private List<Wallpaper> wallpaperList = new List<Wallpaper>();

        public AutoForm()
        {
            InitializeComponent();
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            //AllocConsole();
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string[] paths = Directory.GetFiles(fbd.SelectedPath);

                    foreach (string path in paths)
                    {
                        Wallpaper wp = new Wallpaper(path);
                        wallpaperList.Add(wp);
                    }

                    selectLabel.Text = paths.Length.ToString() + " Wallpapers found.";
                }
            }
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            using (TaskService ts = new TaskService())
            {
                TaskDefinition td = ts.NewTask();
                td.RegistrationInfo.Description = "Changes wallpaper periodically";

                td.Triggers.Add(new DailyTrigger { DaysInterval = 1 });

                td.Actions.Add(new ExecAction("C:/Users/rmbas/Desktop/Projects/WallpaperGen/WallpaperSwitcher/WallpaperSwitcher/bin/Debug/net6.0-windows/WallpaperSwitcher.exe", null, null));

                ts.RootFolder.RegisterTaskDefinition(@"WallpaperSwitcher", td);
            }
        }
    }
}
