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

    public Animator m_Animator;
    [SerializeField] private bool F_Slide = true;

    [Header("+1 Score")]
    [SerializeField] private Transform UiSpawn;
    [SerializeField] private GameObject ScorePlus;

    [Header("Slider Text")]
    [SerializeField] private TextMeshProUGUI ObjectiveNb;
    [SerializeField] private TextMeshProUGUI CurrentSco;

    [Header("Sound")]
    [SerializeField] private AudioSource source;
    [SerializeField] private AudioClip Transi;

    [Header("Reputation text")]
    [SerializeField] private GameObject TreeOne;
    [SerializeField] private GameObject TreeTwo;
    [SerializeField] private GameObject TreeThree;
    [SerializeField] private GameObject TreeFour;
    
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

        CurrentSco.text = CurrentSlider.ToString();

        if (MaxSlider == 5 && CurrentSlider == 5)
        {
            TreeOne.SetActive(true);
        }
        if (MaxSlider == 15 && CurrentSlider == 15)
        {
            TreeTwo.SetActive(true);
        }
        if (MaxSlider == 25 && CurrentSlider == 25)
        {
            TreeThree.SetActive(true);
        }
        if (MaxSlider == 35 && CurrentSlider == 35)
        {
            TreeFour.SetActive(true);
        }

        if (CurrentSlider >= MaxSlider && F_Slide)
        {
            //Debug.Log("Plus");
            m_Animator.SetTrigger("Achieved");
            source.PlayOneShot(Transi);
            ScorePlusPlus();
        }

        Instantiate(ScorePlus, UiSpawn.transform);
    }

    public void ScorePlusPlus()
    {
        CurrentSlider = MinSlider;
        CurrentSco.text = CurrentSlider.ToString();
        MaxSlider += 10;
        RepSlider.value = CurrentSlider;
        RepSlider.maxValue = MaxSlider;

        ObjectiveNb.text = MaxSlider.ToString();
    }
}
