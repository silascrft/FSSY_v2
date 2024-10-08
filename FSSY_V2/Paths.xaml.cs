﻿using System.ComponentModel;
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

        //Back Button Events
        private void NavigateBack(object sender, RoutedEventArgs e)
        {
            
            {
                SavePaths();
            }

            {
                var mainWindow = (MainWindow)Window.GetWindow(this);
                mainWindow.NavigateToMenuPage();
            }
        }

        
        //Quit Button Event
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
