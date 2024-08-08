using System;
using System.IO;
using Newtonsoft.Json;

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

public class SavegameStates
{
    private readonly string _folderPath;
    private readonly string _filePath;

    public SavegameStates()
    {
        _folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "FSSY");
        _filePath = Path.Combine(_folderPath, "checkboxStates.json");
        Directory.CreateDirectory(_folderPath); // Ordner erstellen, falls er nicht existiert
    }

    public void Save(CheckBoxState state)
    {
        string json = JsonConvert.SerializeObject(state);
        File.WriteAllText(_filePath, json);
    }

    public CheckBoxState Load()
    {
        if (File.Exists(_filePath))
        {
            string json = File.ReadAllText(_filePath);
            return JsonConvert.DeserializeObject<CheckBoxState>(json);
        }
        return new CheckBoxState(); // Rückgabe eines leeren Zustands, falls die Datei nicht existiert
    }
}
