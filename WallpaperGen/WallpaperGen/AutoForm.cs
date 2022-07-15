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
        private Scheduler scheduler = new Scheduler();

        public AutoForm()
        {
            InitializeComponent();
            folderPanel.Hide();
            homePanel.Dock = DockStyle.Fill;
            homePanel.Show();
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            addFolderWallpapers();
            selectLabel.Text = scheduler.WallpaperList.Count.ToString() + " Wallpapers found.";
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            scheduler.RemoveTask();
            scheduler.ScheduleTask();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            scheduler.RemoveTask();
        }


        private void addFolderWallpapers()
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string[] files = Directory.GetFiles(fbd.SelectedPath);
                    foreach (string file in files)
                    {
                        scheduler.WallpaperList.Add(new Wallpaper(file));
                    }
                }
            }
        }

        private void homeNextButton_Click(object sender, EventArgs e)
        {
            if (folderRadio.Checked)
            {
                homePanel.Hide();
                folderPanel.Show();
                folderPanel.Dock = DockStyle.Fill;
            }
        }

        private void folderBackButton_Click(object sender, EventArgs e)
        {
            folderPanel.Hide();
            homePanel.Show();
        }

        private void folderNextButton_Click(object sender, EventArgs e)
        {

        }

        private void folderRadio_CheckedChanged(object sender, EventArgs e)
        {
            homeNextButton.Enabled = true;
        }

        private void generateRadio_CheckedChanged(object sender, EventArgs e)
        {
            homeNextButton.Enabled = true;
        }
    }
}
