using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Navigation;

using GameLauncherLibrary;
namespace GameLauncherTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
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
    }
}
