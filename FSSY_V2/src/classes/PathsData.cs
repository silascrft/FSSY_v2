using Newtonsoft.Json;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows;
using System.IO;
using System.Windows.Controls.Primitives;
using System;
using FSSY_V2;

public class PathsManager
{
    public List<string> paths { get; set; } = new List<string>();
    private readonly string _folderPath;
    private readonly string _filePath;

    public PathsManager()
    {
        _folderPath = MainWindow.FOLDER_PATH;
        _filePath = Path.Combine(_folderPath, "paths.json");
        Directory.CreateDirectory(_folderPath);
    }


    public void SavePathsToFile(UniformGrid uniformGrid)
    {
        PathsManager pathsData = new PathsManager();

        foreach (UIElement element in uniformGrid.Children)
        {
            if (element is Grid grid)
            {
                foreach (var child in grid.Children)
                {
                    if (child is TextBox textBox)
                    {
                        pathsData.paths.Add(textBox.Text);
                    }
                }
            }
        }

        string json = JsonConvert.SerializeObject(pathsData, Formatting.Indented);
        File.WriteAllText(_filePath, json);
    }

    public void LoadPathsFromFile(UniformGrid uniformGrid)
    {
        if (File.Exists(_filePath))
        {
            string json = File.ReadAllText(_filePath);
            PathsManager pathsData = JsonConvert.DeserializeObject<PathsManager>(json);

            for (int i = 0; i < pathsData.paths.Count && i < uniformGrid.Children.Count; i++)
            {
                if (uniformGrid.Children[i] is Grid grid)
                {
                    foreach (var child in grid.Children)
                    {
                        if (child is TextBox textBox)
                        {
                            textBox.Text = pathsData.paths[i];
                        }
                    }
                }
            }
        }
    }
}

