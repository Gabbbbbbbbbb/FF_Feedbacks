using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    public AudioListener Listen;
    public Slider s_slider;
    [SerializeField] private float maxSlider = 1.0f;
    [SerializeField] private float minSlider = 0.0f;

    public static SoundManager Instance;

    public void Awake()
    {
        if (Instance == null)
        {
            Instance = null;
        }
    }

    // No need for custom currentValue since we can say that AudioListener.volume equals to the slider directly. Less code.
    void Start()
    {
        s_slider.maxValue = maxSlider;
        s_slider.minValue = minSlider;
        AudioListener.volume = s_slider.value;
    }

    // Code that makes the AudioListener update depending on the value of the Slider.
    void Update()
    {
        AudioListener.volume = s_slider.value;
    }
}
