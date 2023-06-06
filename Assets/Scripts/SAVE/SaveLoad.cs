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

    //This script allows us to create a json file and to "write" on it by using buttons. 

    private void Start()
    {
        LoadFile();
        LoadFileSecond();
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

    public void DeleteFile()
    {
        File.Delete(Application.persistentDataPath + "/data.save");
    }



    public void SaveToFileSecond()
    {
        saveInfo.Save();
        string json = JsonUtility.ToJson(saveInfo);
        if (!File.Exists(Application.persistentDataPath + "/datas.save"))
        {
            File.Create(Application.persistentDataPath + "/datas.save").Dispose();
        }

        File.WriteAllText(Application.persistentDataPath + "/datas.save", json);
    }

    public void LoadFileSecond()
    {
        if (File.Exists(Application.persistentDataPath + "/datas.save"))
        {
            string json = File.ReadAllText(Application.persistentDataPath + "/datas.save");
            saveInfo = JsonUtility.FromJson<SaveInfo>(json);
            saveInfo.Load();
        }
        else
        {
            saveInfo = new SaveInfo();
        }
    }

    public void DeleteFileSecond()
    {
        File.Delete(Application.persistentDataPath + "/datas.save");
    }



    //Idk about a list. I want to try an array + 4 save file + inputfield to choose save file name... Idk how to do that (yet) and it is taking too much of my time rn.


    /*public void AllFiles()
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
    }*/
}
