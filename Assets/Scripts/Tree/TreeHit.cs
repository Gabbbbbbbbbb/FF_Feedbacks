using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TreeHit : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private GameObject Sound;

    [Header("Texte")]
    [SerializeField] private TextMeshProUGUI ScoreText;
    int Value = 0;

    [Header("Slider")]
    [SerializeField] private Slider RepSlider;
    [SerializeField] private int MinSlider = 0;
    [SerializeField] private int MaxSlider = 5;
    [SerializeField] private int CurrentSlider;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        RepSlider.maxValue = MaxSlider;
        RepSlider.minValue = MinSlider;
        CurrentSlider = MinSlider;
    }

    // Update is called once per frame
    void Update()
    {
        //Used to detect if something is moving (using his Rigidbody).
        if (rb.velocity.x > 0 || rb.velocity.y > 0)
        {
            //Debug.Log("It's moving");
            Sound.SetActive(true);
            Destroy(Sound, 5);
        }
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Terrain"))
        {
            Debug.Log("The ground");
            Value++;
            ScoreText.text = Value.ToString();

            CurrentSlider++;
            RepSlider.value = CurrentSlider;
        }
    }
    //bool pour indiquer quelle slider est actif ou non. À vérif dès qu'il y a collision.
}
