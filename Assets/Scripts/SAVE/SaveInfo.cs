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
    public SoundManager soundManager;

    [Header("Stocking")]
    //public Slider SoundSlider;
    public AudioListener SoundSlider;

    //The script allows the storage of data (by using "Data PlaceHolder").

    public SaveInfo()
    {
        if (SoundManager.Instance != null) soundManager = SoundManager.Instance;
    }


    public void Save()
    {
        if (SoundManager.Instance != null) 
        {
            SoundSlider = soundManager.Listen;
            // Test, not working rn (need to convert things to numbers I guess ?? SoundSlider = soundManager.s_slider;
        }
    }

    public void Load()
    {
        SoundManager.Instance.Listen = SoundSlider;
    }
}
