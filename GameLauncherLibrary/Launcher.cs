using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows;
using System.Net;

namespace GameLauncherLibrary
{
    public class Launcher
    {

        static string exePath = Directory.GetCurrentDirectory() + "/LeapOfChampions.exe";
        static string versionUrl = "http://download1153.mediafire.com/f2f7i8rs18ng/iswfmbhtziwahit/version.txt"; 

        public static void PlayGame(){
            Process.Start(exePath);
        }

        public static void LaunchWebsite(string url) {
            Process.Start(url);
        }

        public static bool CheckUpdate() {
            string currentVersion = System.IO.File.ReadAllText("./version.txt");
            using (var client = new WebClient())
            {
                client.DownloadFile(versionUrl, "CurrentVersion.txt");
            }
            string downloadedVersion = System.IO.File.ReadAllText("./CurrentVersion.txt");
            System.IO.File.Delete("./CurrentVersion.txt");
            return downloadedVersion == currentVersion;
            //return true;
        }
    }
}
