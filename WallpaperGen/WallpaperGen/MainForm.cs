using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Net.Http.Formatting;
using Newtonsoft.Json.Linq;
using System.Net;
using System.IO;

namespace WallpaperGen
{
    public partial class MainForm : Form
    {
        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        private static extern bool AllocConsole();

        private const int MAX_WP = 10;
        private const string URL = "https://wallhaven.cc/api/v1/search";
        private string urlParameters = "?q=nature&categories=100&atleast=1920x1080&sorting=views";
        private List<Wallpaper> wallpaperList = new List<Wallpaper>();
        private int listIndex = 0;


        public MainForm()
        {
            InitializeComponent();
        }

        private async void getWallpapersButton_Click(object sender, EventArgs e)
        {
            AllocConsole();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(URL);

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            // List data response.
            HttpResponseMessage response = client.GetAsync(urlParameters).Result;  // Blocking call! Program will wait here until a response is received or a timeout occurs.
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body.
                string resultString = response.Content.ReadAsStringAsync().Result;
                JObject json = JObject.Parse(resultString);

                for (int i = 0; i < MAX_WP; i++)
                {
                    JObject wp = (JObject)json["data"][i];
                    wallpaperList.Add(createWallpaper(wp));
                }

                loadWallpapers();
            }
            else
            {
                Console.WriteLine("Error");
            }

            // Make any other calls using HttpClient here.

            // Dispose once all HttpClient calls are complete. This is not necessary if the containing object will be disposed of; for example in this case the HttpClient instance will be disposed automatically when the application terminates so the following call is superfluous.
            client.Dispose();
        }

        private Wallpaper createWallpaper(JObject wp)
        {
            if (wp != null)
            {
                string[] thumbArr = new string[3];
                thumbArr[0] = (string)wp["thumbs"]["large"];
                thumbArr[1] = (string)wp["thumbs"]["original"];
                thumbArr[2] = (string)wp["thumbs"]["small"];

                Wallpaper wallpaper = new Wallpaper(wp["id"].ToString(), wp["path"].ToString(), thumbArr, wp["resolution"].ToString());
                return wallpaper;
            }
            return null;

        }

        private void loadWallpapers()
        {
            if (wallpaperList.Count > 0)
            {
                wallpaperPictureBox.Load(wallpaperList.First().thumbs[0]);
                Console.WriteLine(listIndex);
            }

        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (listIndex < wallpaperList.Count - 1)
            {
                listIndex++;
                wallpaperPictureBox.Load(wallpaperList[listIndex].thumbs[0]);
            }
            else
            {
                if (wallpaperList.Count > 0)
                {
                    wallpaperPictureBox.Load(wallpaperList.First().thumbs[0]);
                    listIndex = 0;
                }
            }

            Console.WriteLine(listIndex);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (listIndex > 0)
            {
                listIndex--;
                wallpaperPictureBox.Load(wallpaperList[listIndex].thumbs[0]);
            }
            else
            {
                if (wallpaperList.Count > 0)
                {
                    wallpaperPictureBox.Load(wallpaperList.Last().thumbs[0]);
                    listIndex = wallpaperList.Count - 1;
                }
            }

            Console.WriteLine(listIndex);
        }

        private void downloadButton_Click(object sender, EventArgs e)
        {
            using (WebClient client = new WebClient())
            {
                for (int i = 0; i < wallpaperList.Count; i++)
                {
                    string filename =  "wallpaper" + (i + 1).ToString() + ".jpg";
                    client.DownloadFile(new Uri(wallpaperList[i].url), @filename);
                }
            }
        }

        private void setWallpapers_Click(object sender, EventArgs e)
        {
            AllocConsole();
            Wallpaper wp = new Wallpaper();
            string root = Path.GetFullPath(".");
            string name = "wallpaper2.jpg";
            string path = Path.Combine(root, name);
            Console.WriteLine(path);
            if (File.Exists(path))
            {
                wp.setWallpaper(@path);
            }
            
        }
    }

    
}


/*
foreach (Wallpaper wp in wallpaperList)
{
    Console.WriteLine("~~~~~~~");
    Console.WriteLine(wp.id);
    Console.WriteLine(wp.url);
    foreach (string thumb in wp.thumbs)
    {
        Console.WriteLine(thumb);
    }
    Console.WriteLine(wp.resolution);

}
*/