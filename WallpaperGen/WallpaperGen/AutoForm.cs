using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WallpaperGen
{
    public partial class AutoForm : Form
    {
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
                    string[] files = Directory.GetFiles(fbd.SelectedPath);

                    foreach (string file in files)
                    {

                    }

                    selectLabel.Text = files.Length.ToString() + " Wallpapers found.";
                }
            }
        }
    }
}
