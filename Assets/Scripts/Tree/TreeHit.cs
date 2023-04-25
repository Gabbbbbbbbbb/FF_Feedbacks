using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TreeHit : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject Sound;

    //For the score.
    public TextMeshProUGUI ScoreText;
    int Value = 0;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //rb.velocity = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        //Used to detect if something is moving (using his Rigidbody).
        if (rb.velocity.x > 0 || rb.velocity.y > 0)
        {
            Debug.Log("It's moving");
            Sound.SetActive(true);
            Destroy(Sound, 5);
        }
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Terrain"))
        {
            //Debug.Log("The ground");
            Value = Value + 1;
            ScoreText.text = Value.ToString();
            

        }
    }


    //Ancient code to detect when a tree is hit by the projectile.

    /*void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Projectile"))
        {
            Sound.SetActive(true);
            Destroy(Sound, 5);
        }
    }

    void OnColliderEnter(Collider tree)
    {
        if (tree.CompareTag("Projectile"))
        {
            Sound.SetActive(true);
            Destroy(Sound, 5);
        }
    }*/
}
