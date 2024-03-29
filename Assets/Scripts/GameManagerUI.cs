using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class GameManagerUI : MonoBehaviour
{
    public static GameManagerUI instance;

    [Header("Slider")]
    public Slider RepSlider;
    [SerializeField] private int MinSlider = 0;
    public int MaxSlider = 5;
    public int CurrentSlider;

    [Header("Texte")]
    [SerializeField] private TextMeshProUGUI ScoreText;
    public int Value = 0;

    public Animator m_Animator;
    [SerializeField] private bool F_Slide = true;

    [Header("+1 Score")]
    [SerializeField] private Transform UiSpawn;
    [SerializeField] private GameObject ScorePlus;

    [Header("Slider Text")]
    public TextMeshProUGUI ObjectiveNb;
    public TextMeshProUGUI CurrentSco;

    [Header("Sound")]
    [SerializeField] private AudioSource source;
    [SerializeField] private AudioClip Transi;

    [Header("Reputation text")]
    [SerializeField] private GameObject TreeOne;
    [SerializeField] private GameObject TreeTwo;
    [SerializeField] private GameObject TreeThree;
    [SerializeField] private GameObject TreeFour;

    [Header("Rocks")]
    [SerializeField] private Slider RockSlider;
    [SerializeField] private int MinRock = 0;
    public int MaxRock = 10;
    public int CurrentRocks;
    [SerializeField] private TextMeshProUGUI ScoreRock;
    [SerializeField] private TextMeshProUGUI ObjectiveR;
    [SerializeField] private Animator r_Animator;

    [Header("Reputation Rock")]
    [SerializeField] private GameObject RockOne;
    [SerializeField] private GameObject RockTwo;

    [Header("End Objectives")]
    [SerializeField] bool R_Slide = true;

    [Header("Save Menu")]
    [SerializeField] private GameObject MenuSave;
    [SerializeField] private GameObject MenuLoad;

    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    //This script gets called by the TreeHit script to update the score and Slider.
    void Start()
    {
        RepSlider.maxValue = MaxSlider;
        RepSlider.minValue = MinSlider;
        CurrentSlider = MinSlider;

        RockSlider.maxValue = MaxRock;
        RockSlider.minValue = MinRock;
        CurrentRocks = MinRock;
    }

    //Called by the TreeHit script.
    public void Gain()
    {
        //Debug.Log("Gain");
        CurrentSlider++;

        Value++;

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
            F_Slide = false;
            m_Animator.SetTrigger("END");
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
        MaxSlider += 10;
    }

    //Called by the RocksHit script.
    public void Rock()
    {
        CurrentRocks++;
        RockSlider.value = CurrentRocks;

        

        if (MaxRock == 10 && CurrentRocks == 10)
        {
            RockOne.SetActive(true);
        }

        if (MaxRock == 20 && CurrentRocks == 20)
        {
            RockTwo.SetActive(true);
            r_Animator.SetTrigger("END");
            R_Slide = false;
        }

        if (CurrentRocks >= MaxRock && R_Slide)
        {
            //Debug.Log("Plus");
            r_Animator.SetTrigger("Achieved");
            source.PlayOneShot(Transi);
            MaxRock += 10;
            CurrentRocks = 0;

            ScoreRock.text = CurrentRocks.ToString();
            ObjectiveR.text = MaxRock.ToString();
        }
    }

    void Update()
    {
        ScoreText.text = Value.ToString();
        CurrentSco.text = CurrentSlider.ToString();
        RepSlider.value = CurrentSlider;
        RepSlider.maxValue = MaxSlider;
        ObjectiveNb.text = MaxSlider.ToString();
        RepSlider.value = CurrentSlider;

        ScoreRock.text = CurrentRocks.ToString();
        ObjectiveR.text = MaxRock.ToString();
        RockSlider.maxValue = MaxRock;
        RockSlider.value = CurrentRocks;

    }

    #region Save&Load
    public void SaveFilesB()
    {
        MenuSave.SetActive(true);
    }
    public void SaveFilesDisappear()
    {
        MenuSave.SetActive(false);
    }

    public void LoadFilesAppear()
    {
        MenuLoad.SetActive(true);
    }
    public void LoadFilesDisappear()
    {
        MenuLoad.SetActive(false);
    }
    #endregion
}
