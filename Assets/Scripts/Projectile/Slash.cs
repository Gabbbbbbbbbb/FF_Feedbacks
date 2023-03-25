using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slash : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 30f;

    //Pour spawn les particules.
    public GameObject HitSlash;
    public Transform spawn;

    void Update()
    {
        rb.velocity = transform.forward * speed;
        Destroy(gameObject, 3);
    }

    void OnTriggerEnter(Collider collision)
    {
        Instantiate(HitSlash, spawn.position, spawn.rotation);

        Destroy(gameObject);
    }
}
