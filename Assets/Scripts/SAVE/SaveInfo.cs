using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SaveInfo : MonoBehaviour
{
    //public Slider SoundSlider;
    public AudioListener SoundSlider;
    public SoundManager SoundManager;

    public void Save()
    {
        if (SoundManager.Instance != null) 
        {
            SoundSlider = SoundManager.Listen;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
