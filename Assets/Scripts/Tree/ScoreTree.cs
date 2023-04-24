using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTree : MonoBehaviour
{
    public Text ValueText;
    int ScoreValue = 1;

    void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Terrain"))
        {
            ValueText.text = ("ScoreValue");
        }
    }
}
