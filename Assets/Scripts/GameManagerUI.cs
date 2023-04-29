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
    //int Obje = 5;

    //This script gets called by the TreeHit script to update the score and Slider.
    void Start()
    {
        RepSlider.maxValue = MaxSlider;
        RepSlider.minValue = MinSlider;
        CurrentSlider = MinSlider;

        m_Animator.gameObject.GetComponent<Animator>();

        //ObjectiveNb.text = MaxSlider.ToString();
    }

    //Called by the TreeHit script.
    public void Gain()
    {
        //Debug.Log("Gain");
        CurrentSlider++;
        RepSlider.value = CurrentSlider;

        Value++;
        ScoreText.text = Value.ToString();

        if(CurrentSlider >= MaxSlider && F_Slide)
        {
            //Debug.Log("Plus");
            m_Animator.SetTrigger("Achieved");

            ScorePlusPlus();
        }

        Instantiate(ScorePlus, UiSpawn.transform);
    }

    public void ScorePlusPlus()
    {
        CurrentSlider = 0;
        MaxSlider += 5;
        RepSlider.value = CurrentSlider;
        RepSlider.maxValue = MaxSlider;

        ObjectiveNb.text = MaxSlider.ToString();
    }
}
