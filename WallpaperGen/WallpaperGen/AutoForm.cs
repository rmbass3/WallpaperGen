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
            
            homePanel.Dock = DockStyle.Fill;
            folderPanel.Dock = DockStyle.Fill;
            schedulePanel.Dock = DockStyle.Fill;

            homePanel.Show();
            folderPanel.Hide();
            schedulePanel.Hide();
        }

        // Home Panel

        private void removeButton_Click(object sender, EventArgs e)
        {
            scheduler.RemoveTask();
        }

        // Folder Panel

        private void selectFolderButton_Click(object sender, EventArgs e)
        {
            addFolderWallpapers();
            int count = scheduler.WallpaperList.Count;
            selectLabel.Text = count.ToString() + " Wallpapers found.";
            if (count > 0)
            {
                folderNextButton.Enabled = true;
            } else
            {
                folderNextButton.Enabled = false;
            }
        }

        // Schedule Panel


        // Radios

        private void folderRadio_CheckedChanged(object sender, EventArgs e)
        {
            homeNextButton.Enabled = true;
        }

        private void generateRadio_CheckedChanged(object sender, EventArgs e)
        {
            homeNextButton.Enabled = true;
        }

        private void dailyRadio_CheckedChanged(object sender, EventArgs e)
        {
            scheduleNextButton.Enabled = true;
        }

        private void computerStartRadio_CheckedChanged(object sender, EventArgs e)
        {
            scheduleNextButton.Enabled = true;
        }

        // Next and Back Buttons

        private void homeNextButton_Click(object sender, EventArgs e)
        {
            if (folderRadio.Checked)
            {
                homePanel.Hide();
                folderPanel.Show();
            }
        }

        private void folderBackButton_Click(object sender, EventArgs e)
        {
            folderPanel.Hide();
            homePanel.Show();
        }

        private void folderNextButton_Click(object sender, EventArgs e)
        {
            folderPanel.Hide();
            schedulePanel.Show();
        }

        private void scheduleBackButton_Click(object sender, EventArgs e)
        {
            schedulePanel.Hide();
            folderPanel.Show();
        }

        private void scheduleNextButton_Click(object sender, EventArgs e)
        {
           
        }

        // Functions
        private void addFolderWallpapers()
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string[] pngFiles = Directory.GetFiles(fbd.SelectedPath, "*.png");
                    string[] jpgFiles = Directory.GetFiles(fbd.SelectedPath, "*.jpg");
                    var files = pngFiles.Concat(jpgFiles);
                    foreach (string file in files)
                    {
                        scheduler.WallpaperList.Add(new Wallpaper(file));
                    }
                }
            }
        }


    }
}
