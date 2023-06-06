using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[Serializable]
public class SaveInfo
{

    [Header("Scripts")]
    public SoundManager soundManager;
    public GameManagerUI gameManagerUI;

    [Header("Stocking")]
    public int score;
    public float volumeSlider;
    public int TreeSliderValue;
    public int MaxTreeSlider;

    public int RockSliderValue;
    public int MaxRockSlider;

    //The script allows the storage of data (by using "Data PlaceHolder").


    public void Save()
    {
        if (SoundManager.Instance != null)
        {
            volumeSlider = SoundManager.Instance.s_slider.value;
        }
        if (GameManagerUI.instance != null)
        {
            score = GameManagerUI.instance.Value;
            TreeSliderValue = GameManagerUI.instance.CurrentSlider;
            MaxTreeSlider = GameManagerUI.instance.MaxSlider;
            RockSliderValue = GameManagerUI.instance.CurrentRocks;
            MaxRockSlider = GameManagerUI.instance.MaxRock;
        }
    }

    public void Load()
    {
        GameManagerUI.instance.Value = score;
        GameManagerUI.instance.CurrentSlider = TreeSliderValue;
        GameManagerUI.instance.MaxSlider = MaxTreeSlider;
        GameManagerUI.instance.CurrentRocks = RockSliderValue;
        GameManagerUI.instance.MaxRock = MaxRockSlider;

        SoundManager.Instance.s_slider.value = volumeSlider;
    }
}
