using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using UnityEngine.UIElements;
using TMPro;


public class SaveLoad : MonoBehaviour
{
    public SaveInfo saveInfo;
    public TMP_Dropdown Dropdown;

    //This script allows us to create a json file and to "write" on it by using buttons. 

    private void Start()
    {
        LoadFile();
        AllFiles();
    }


    public void SaveToFile()
    {
        saveInfo.Save();
        string json = JsonUtility.ToJson(saveInfo);
        if (!File.Exists(Application.persistentDataPath + "/data.save"))
        {
            File.Create(Application.persistentDataPath + "/data.save").Dispose();
        }

        File.WriteAllText(Application.persistentDataPath + "/data.save", json);

        AllFiles();
    }

    public void LoadFile()
    {
        if (File.Exists(Application.persistentDataPath + "/data.save"))
        {
            string json = File.ReadAllText(Application.persistentDataPath + "/data.save");
            saveInfo = JsonUtility.FromJson<SaveInfo>(json);
            saveInfo.Load();
        }
        else
        {
            saveInfo = new SaveInfo();
        }
    }

    public void AllFiles()
    {
        List<string> possibleSaveFiles = new List<string>();

        DirectoryInfo info = new DirectoryInfo(Application.persistentDataPath);
        FileInfo[] fileInfo = info.GetFiles();
        foreach (FileInfo file in fileInfo)
        {
            if (file.Name.Contains(".save"))
            {
                possibleSaveFiles.Add(file.Name);
                
            }
        }
        Dropdown.AddOptions(possibleSaveFiles);
    }
}
