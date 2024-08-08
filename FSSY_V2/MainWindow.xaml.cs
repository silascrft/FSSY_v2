using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace FSSY_V2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static readonly string FOLDER_PATH = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "FSSY");

        Paths paths = new Paths();
        Menu menu = new Menu();

        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(menu);    
        }

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ButtonState == MouseButtonState.Pressed)
            {
                this.DragMove(); // Fenster bewegen
            }
        }
        private void MinimizeButton(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized; // Fenster minimieren
        }
        private void ExitButton(object sender, RoutedEventArgs e)
        {
            this.Close(); // Fenster schließen
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            menu.SaveOnClose(sender, e);
            paths.SaveOnClose(sender, e);
        }

        public void NavigateToPathPage()
        {
            MainFrame.Navigate(paths);
        }

        public void NavigateToMenuPage()
        {
            MainFrame.Navigate(menu);
        }
    }
}
