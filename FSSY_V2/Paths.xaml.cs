using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
    /// Interaction logic for Paths.xaml
    /// </summary>
    public partial class Paths : Page
    {

        private PathsManager _pathsManager;

        public Paths()
        {
            InitializeComponent();
            _pathsManager = new PathsManager();
            LoadPathsFromFile();
        }

        public void SaveOnClose(object sender, CancelEventArgs e)
        {
            SavePaths();
        }

        private void NavigateBack(object sender, RoutedEventArgs e)
        {
            var mainWindow = (MainWindow)Window.GetWindow(this);
            mainWindow.NavigateToMenuPage();
        }

        public void SavePaths()
        {
            _pathsManager.SavePathsToFile(PathsGrid);
        }

        private void LoadPathsFromFile()
        {
            _pathsManager.LoadPathsFromFile(PathsGrid);
        }

    }
}
