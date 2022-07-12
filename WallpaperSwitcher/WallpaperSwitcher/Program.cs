using System.Runtime.InteropServices;
using Microsoft.Win32;
using System.Diagnostics;

namespace WallpaperSwitcher
{
    public class Program
    {
        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        private static extern bool AllocConsole();

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SystemParametersInfo(UInt32 action, UInt32 uParam, String vParam, UInt32 winIni);

        private static readonly UInt32 SPI_SETDESKWALLPAPER = 0x14;
        private static readonly UInt32 SPIF_UPDATEINIFILE = 0x01;
        private static readonly UInt32 SPIF_SENDWININICHANGE = 0x02;

        static void Main(string[] args)
        {
            //AllocConsole();
            if (args.Length == 0) return;
            string cWall = getCurrentWallpaper();
            
            string match = findMatchingWallpaper(args, cWall);

            string wp = selectWallpaper(args, match);
            if (wp != null)
            {
                setWallpaper(@wp);
            }
            
            //Console.ReadLine();
        }

        public static void setWallpaper(string path)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Control Panel\Desktop", true);
            key.SetValue(@"WallpaperStyle", 0.ToString()); // 2 is stretched
            key.SetValue(@"TileWallpaper", 0.ToString());

            SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, path, SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE);
        }

        public static string getCurrentWallpaper()
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Control Panel\Desktop"))
            {
                if (key != null)
                {
                    Object o = key.GetValue("WallPaper");
                    if (o != null)
                    {
                        return o.ToString();
                    }
                }
            }
            return null;
        }
            

        public static string findMatchingWallpaper(string[] args, string cWall)
        {
            //AllocConsole();
            //Console.WriteLine("cWall: " + cWall);
            foreach (string arg in args)
            {
                //Console.WriteLine("arg: " + arg);
                if (arg == cWall)
                {
                    //Console.WriteLine("true");
                    return arg;
                }
            }
            return null;
        }

        public static string selectWallpaper(string[] args, string match)
        {
            /*
            AllocConsole();

            Console.WriteLine("match: " + match);

            foreach (string arg in args)
            {
                Console.WriteLine(arg);
            }
            */

            if (match != null)
            {
                args = Array.FindAll(args, arg => arg != match).ToArray();
            }

            Random rand = new Random();

            int i = rand.Next(args.Length);

            return args[i];
        }
    }
}