using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

[Serializable]
public class SaveInfo
{

    [Header("Scripts")]
    //public SoundManager soundManager;
    public GameManagerUI gameManagerUI;

    [Header("Stocking")]
    //public Slider SoundSlider;
    //public AudioListener SoundSlider;
    public int score;

    //The script allows the storage of data (by using "Data PlaceHolder").


    public void Save()
    {
        /*if (SoundManager.Instance != null) 
        {
            SoundSlider = SoundManager.Instance.Listen;
            // Test, not working rn (need to convert things to numbers I guess ?? SoundSlider = soundManager.s_slider;
        }*/
        if (GameManagerUI.instance != null)
        {
            score = GameManagerUI.instance.Value;
        }
    }

    public void Load()
    {
        //SoundManager.Instance.Listen = SoundSlider;
        GameManagerUI.instance.Value = score;
    }
}
