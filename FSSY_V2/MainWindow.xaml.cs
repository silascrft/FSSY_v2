using Newtonsoft.Json;
using System;
using System.IO;
using System.Diagnostics;
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
        public MainWindow()
        {
            InitializeComponent();
            LoadCheckBoxStates(); // Zustände der CheckBoxes beim Start der Anwendung laden
        }

        // Event-Handler für das Ziehen des Fensters, wenn die obere Leiste mit der Maus gedrückt wird
        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ButtonState == MouseButtonState.Pressed)
            {
                this.DragMove(); // Fenster bewegen
            }
        }

        // Event-Handler für die Schaltfläche zum Minimieren des Fensters
        private void MinimizeButton(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized; // Fenster minimieren
        }

        // Event-Handler für die Schaltfläche zum Schließen des Fensters
        private void ExitButton(object sender, RoutedEventArgs e)
        {
            this.Close(); // Fenster schließen
        }

        // Event-Handler für die Schaltfläche zum Starten des Spiels
        private void PlayButton(object sender, RoutedEventArgs e)
        {
            Process.Start(@"C:\Program Files (x86)\Farming Simulator 2022\x64\FarmingSimulator2022Game.exe"); // Spiel starten
        }

        // Event-Handler für das Schließen des Fensters
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            SaveCheckBoxStates(); // Zustände der CheckBoxes beim Schließen der Anwendung speichern
        }

        // Klasse zur Speicherung der Zustände der CheckBoxes
        public class CheckBoxState
        {
            public bool CheckBox1 { get; set; }
            public bool CheckBox2 { get; set; }
            public bool CheckBox3 { get; set; }
            public bool CheckBox4 { get; set; }
            public bool CheckBox5 { get; set; }
            public bool CheckBox6 { get; set; }
            public bool CheckBox7 { get; set; }
            public bool CheckBox8 { get; set; }
            public bool CheckBox9 { get; set; }
            public bool CheckBox10 { get; set; }
            public bool CheckBox11 { get; set; }
            public bool CheckBox12 { get; set; }
            public bool CheckBox13 { get; set; }
            public bool CheckBox14 { get; set; }
            public bool CheckBox15 { get; set; }
            public bool CheckBox16 { get; set; }
            public bool CheckBox17 { get; set; }
            public bool CheckBox18 { get; set; }
            public bool CheckBox19 { get; set; }
            public bool CheckBox20 { get; set; }
            // Weitere CheckBox-Properties können hinzugefügt werden
        }

        // Methode zum Speichern der Zustände der CheckBoxes
        private void SaveCheckBoxStates()
        {
            // Erstellen eines Objekts, das die Zustände der CheckBoxes enthält
            CheckBoxState state = new CheckBoxState
            {
                CheckBox1 = checkBox1.IsChecked ?? false,
                CheckBox2 = checkBox2.IsChecked ?? false,
                CheckBox3 = checkBox3.IsChecked ?? false,
                CheckBox4 = checkBox4.IsChecked ?? false,
                CheckBox5 = checkBox5.IsChecked ?? false,
                CheckBox6 = checkBox6.IsChecked ?? false,
                CheckBox7 = checkBox7.IsChecked ?? false,
                CheckBox8 = checkBox8.IsChecked ?? false,
                CheckBox9 = checkBox9.IsChecked ?? false,
                CheckBox10 = checkBox10.IsChecked ?? false,
                CheckBox11 = checkBox11.IsChecked ?? false,
                CheckBox12 = checkBox12.IsChecked ?? false,
                CheckBox13 = checkBox13.IsChecked ?? false,
                CheckBox14 = checkBox14.IsChecked ?? false,
                CheckBox15 = checkBox15.IsChecked ?? false,
                CheckBox16 = checkBox16.IsChecked ?? false,
                CheckBox17 = checkBox17.IsChecked ?? false,
                CheckBox18 = checkBox18.IsChecked ?? false,
                CheckBox19 = checkBox19.IsChecked ?? false,
                CheckBox20 = checkBox20.IsChecked ?? false,
                // Weitere CheckBoxes können hinzugefügt werden
            };

            // Pfad zum Ordner "FSSY" im Dokumentenverzeichnis des aktuellen Benutzers
            string folderPath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "FSSY");
            Directory.CreateDirectory(folderPath); // Ordner erstellen, falls er nicht existiert

            // Pfad zur JSON-Datei im "FSSY"-Ordner
            string filePath = System.IO.Path.Combine(folderPath, "checkboxStates.json");

            // Zustände der CheckBoxes in JSON-Format serialisieren
            string json = JsonConvert.SerializeObject(state);

            // JSON-String in die Datei schreiben
            File.WriteAllText(filePath, json);
        }

        // Methode zum Laden der gespeicherten Zustände der CheckBoxes
        private void LoadCheckBoxStates()
        {
            // Pfad zum Ordner "FSSY" im Dokumentenverzeichnis des aktuellen Benutzers
            string folderPath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "FSSY");

            // Pfad zur JSON-Datei im "FSSY"-Ordner
            string filePath = System.IO.Path.Combine(folderPath, "checkboxStates.json");

            // Überprüfen, ob die Datei existiert
            if (File.Exists(filePath))
            {
                // JSON-String aus der Datei lesen
                string json = File.ReadAllText(filePath);

                // JSON-String deserialisieren, um ein CheckBoxState-Objekt zu erhalten
                CheckBoxState state = JsonConvert.DeserializeObject<CheckBoxState>(json);

                // Zustände der CheckBoxes wiederherstellen
                checkBox1.IsChecked = state.CheckBox1;
                checkBox2.IsChecked = state.CheckBox2;
                checkBox3.IsChecked = state.CheckBox3;
                checkBox4.IsChecked = state.CheckBox4;
                checkBox5.IsChecked = state.CheckBox5;
                checkBox6.IsChecked = state.CheckBox6;
                checkBox7.IsChecked = state.CheckBox7;
                checkBox8.IsChecked = state.CheckBox8;
                checkBox9.IsChecked = state.CheckBox9;
                checkBox10.IsChecked = state.CheckBox10;
                checkBox11.IsChecked = state.CheckBox11;
                checkBox12.IsChecked = state.CheckBox12;
                checkBox13.IsChecked = state.CheckBox13;
                checkBox14.IsChecked = state.CheckBox14;
                checkBox15.IsChecked = state.CheckBox15;
                checkBox16.IsChecked = state.CheckBox16;
                checkBox17.IsChecked = state.CheckBox17;
                checkBox18.IsChecked = state.CheckBox18;
                checkBox19.IsChecked = state.CheckBox19;
                checkBox20.IsChecked = state.CheckBox20;
                // Weitere CheckBoxes können geladen werden
            }
        }
    }
}
