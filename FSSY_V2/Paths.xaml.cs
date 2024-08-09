using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace FSSY_V2
{
    /// <summary>
    /// Interaction logic for Paths.xaml
    /// </summary>
    public partial class Paths : Page
    {

        private readonly PathsManager _pathsManager;

        public Paths()
        {
            InitializeComponent();
            _pathsManager = new PathsManager();
            LoadPathsFromFile();
        }

        private void NavigateBack(object sender, RoutedEventArgs e)
        {
            var mainWindow = (MainWindow)Window.GetWindow(this);
            mainWindow.NavigateToMenuPage();
        }

        public void SaveOnClose(object sender, CancelEventArgs e)
        {
            SavePaths();
        }

        private void SavePaths()
        {
            _pathsManager.SavePathsToFile(PathsGrid);
        }

        private void LoadPathsFromFile()
        {
            _pathsManager.LoadPathsFromFile(PathsGrid);
        }

    }
}
