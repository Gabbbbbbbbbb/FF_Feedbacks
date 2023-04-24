using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTree : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Terrain"))
        {
            Debug.Log("Into da ground");
        }
    }
}
