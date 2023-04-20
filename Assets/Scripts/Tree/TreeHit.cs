using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeHit : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject Sound;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        rb.velocity = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.velocity.x > 0 || rb.velocity.y > 0)
        {
            Debug.Log("It's moving");
            Sound.SetActive(true);
            Destroy(Sound, 5);
        }
    }

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
