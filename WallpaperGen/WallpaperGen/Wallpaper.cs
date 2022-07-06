using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace WallpaperGen
{
    public class Wallpaper
    {
        public string id { get; set; }
        public string url { get; set; }
        public string[] thumbs { get; set; }
        public string resolution { get; set; }

        public Wallpaper(string id, string url, string[] thumbs, string resolution)
        {
            this.id = id;
            this.url = url;
            this.thumbs = thumbs;
            this.resolution = resolution;
        }
    }
}
