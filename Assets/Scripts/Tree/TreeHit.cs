using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TreeHit : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private GameObject Sound;

    [Header("GameManager Link")]
    public GameManagerUI GameManagerUI;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
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
            //Debug.Log("The ground");
            GameManagerUI.Gain();
        }
    }
    //bool pour indiquer quelle slider est actif ou non. À vérif dès qu'il y a collision.
}
