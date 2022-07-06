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

namespace WallpaperGen
{
    public partial class MainForm : Form
    {
        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        private static extern bool AllocConsole();

        private const string URL = "https://wallhaven.cc/api/v1/search";
        private string urlParameters = "?q=nature";
        private List<Wallpaper> wallpaperList = new List<Wallpaper>();


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
                //Console.WriteLine(json["data"].First().ToString());

                foreach (JObject wp in json["data"])
                {
                    wallpaperList.Add(createWallpaper(wp));
                }

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

    }

    
}
