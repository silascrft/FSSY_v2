using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FSSY_V2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        //Dragable Top-Bar
        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ButtonState == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        //Minimize Button
        private void MinimizeButton(object sender, RoutedEventArgs e)
        { 
            this.WindowState = WindowState.Minimized;
        }


        //Exit Button
        private void ExitButton(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


        //Play Button
        private void PlayButton(object sender, RoutedEventArgs e)
        {
            Process.Start(@"C:\Program Files (x86)\Farming Simulator 2022\x64\FarmingSimulator2022Game.exe");

        }
    }       

}
