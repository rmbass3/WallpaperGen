using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace WallpaperGen
{
    public class Wallpaper
    {
        public string id { get; set; }
        public string url { get; set; }
        public string[] thumbs { get; set; }
        public string resolution { get; set; }

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SystemParametersInfo(UInt32 action, UInt32 uParam, String vParam, UInt32 winIni);

        private static readonly UInt32 SPI_SETDESKWALLPAPER = 0x14;
        private static readonly UInt32 SPIF_UPDATEINIFILE = 0x01;
        private static readonly UInt32 SPIF_SENDWININICHANGE = 0x02;

        public Wallpaper()
        {

        }

        public Wallpaper(string id, string url, string[] thumbs, string resolution)
        {
            this.id = id;
            this.url = url;
            this.thumbs = thumbs;
            this.resolution = resolution;
        }

        public void setWallpaper(string path)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Control Panel\Desktop", true);
            key.SetValue(@"WallpaperStyle", 0.ToString()); // 2 is stretched
            key.SetValue(@"TileWallpaper", 0.ToString());

            SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, path, SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE);
        }


    }
}
