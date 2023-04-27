using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class GameManagerUI : MonoBehaviour
{
    [Header("Slider")]
    [SerializeField] private Slider RepSlider;
    [SerializeField] private int MinSlider = 0;
    [SerializeField] private int MaxSlider = 5;
    [SerializeField] private int CurrentSlider;

    [Header("Texte")]
    [SerializeField] private TextMeshProUGUI ScoreText;
    int Value = 0;

    //This script gets called by the TreeHit script to update the score and Slider.
    void Start()
    {
        RepSlider.maxValue = MaxSlider;
        RepSlider.minValue = MinSlider;
        CurrentSlider = MinSlider;
    }

    //Called by the TreeHit script.
    public void Gain()
    {
        //Debug.Log("Gain");
        CurrentSlider++;
        RepSlider.value = CurrentSlider;

        Value++;
        ScoreText.text = Value.ToString();
    }
}
