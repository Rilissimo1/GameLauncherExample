using System;
using System.IO;
using System.Windows;
using System.Windows.Input;
using System.Windows.Navigation;
using IWshRuntimeLibrary;
using System.Reflection;

using GameLauncherLibrary;
namespace GameLauncherTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow() {
            this.WindowStyle = WindowStyle.None;
            this.ResizeMode = ResizeMode.NoResize;
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            InitializeComponent();
            if (Launcher.CheckUpdate()) {
                update.Content = "Ready!";
            }
            else{
                update.Content = "New version avaiable! Download it from Steam!";
            }
            CreateDesktopShortcut("Leap Of Champions", Environment.GetFolderPath(Environment.SpecialFolder.Desktop), Assembly.GetExecutingAssembly().Location);
            CreateMenuShortcut();
        }

        private void websiteButton_Click(object sender, RoutedEventArgs e)
        {
            Launcher.LaunchWebsite("http://www.leafgs.com/");
        }

        private void launchButton_Click(object sender, RoutedEventArgs e)
        {
            if (Launcher.CheckUpdate()){
                update.Content = "Game is up to date! Launching...";
                Launcher.PlayGame();
                Environment.Exit(0);
            }
            else {
                update.Content = "New version avaiable! Download it from Steam!";
            }
        }

        private void WindowMouseLeftButtonDown(object sender, MouseButtonEventArgs e){
            this.DragMove();
        }

        private void CloseWindow(object sender, RoutedEventArgs e) {
            Environment.Exit(0);
        }

        private void Minimize(object sender, RoutedEventArgs e) {
            this.WindowState = WindowState.Minimized;
        }

        public static void CreateDesktopShortcut(string shortcutName, string shortcutPath, string targetFileLocation){
            string shortcutLocation = System.IO.Path.Combine(shortcutPath, shortcutName + ".lnk");
            WshShell shell = new WshShell();
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutLocation);

            shortcut.Description = "Leap Of Champions Launcher";
            shortcut.IconLocation = Directory.GetCurrentDirectory() + "/Leaf Icon.ico";
            shortcut.TargetPath = targetFileLocation;
            shortcut.WorkingDirectory = Directory.GetCurrentDirectory();
            shortcut.Save();
        }

        private static void CreateMenuShortcut(){
            WshShell shell = new WshShell();
            IWshShortcut MyShortcut;
            MyShortcut = (IWshShortcut)shell.CreateShortcut(Environment.GetFolderPath(Environment.SpecialFolder.StartMenu) + "/Leap Of Champions/LeapOfChampions Launcher.lnk");
            if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.StartMenu) + "/Leap Of Champions")) {
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.StartMenu) + "/Leap Of Champions");
            }
            MyShortcut.TargetPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            MyShortcut.WorkingDirectory = Directory.GetCurrentDirectory();
            MyShortcut.Description = "Launch Leap Of Champions!";
            MyShortcut.Save();
        }
    }
}
