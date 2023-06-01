using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using UnityEngine.UIElements;


public class SaveLoad : MonoBehaviour
{
    private SaveInfo saveInfo;

    //This script allows us to create a json file and to "write" on it by using buttons. It also allows us to 

    private void Start()
    {
        LoadFile();
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
}
