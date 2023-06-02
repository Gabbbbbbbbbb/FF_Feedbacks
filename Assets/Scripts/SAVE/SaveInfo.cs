using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class SaveInfo
{

    [Header("Scripts")]
    public SoundManager soundManager;
    public GameManagerUI gameManagerUI;

    [Header("Stocking")]
    public int score;
    private float volume;

    //The script allows the storage of data (by using "Data PlaceHolder").


    public void Save()
    {
        if (SoundManager.Instance != null)
        {
             volume = SoundManager.Instance.s_slider.value;
        }
        if (GameManagerUI.instance != null)
        {
            score = GameManagerUI.instance.Value;
        }
    }

    public void Load()
    {
        GameManagerUI.instance.Value = score;
        SoundManager.Instance.s_slider.value = volume;
    }
}
