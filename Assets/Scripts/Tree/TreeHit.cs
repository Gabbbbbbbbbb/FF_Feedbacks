using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TreeHit : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private GameObject Sound;
    private bool Once = true;

    [Header("GameManager Link")]
    public GameManagerUI GameManagerUI;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        //Used to detect if something is moving (using his Rigidbody).
        if (rb.velocity.x > 0 || rb.velocity.y > 0)
        {
            if (Once == true)
            {
                Once = false;
                Sound.SetActive(true);
                Destroy(Sound, 5);
            }
        }
    }

    // Script to earn score points when a collider on the tree hits the ground.
    void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Terrain"))
        {
            GameManagerUI.Gain();
        }
    }
}
