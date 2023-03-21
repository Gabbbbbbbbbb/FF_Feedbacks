using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slash : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 30f;

    void Update()
    {
        rb.velocity = transform.forward * speed;
        Destroy(gameObject, 3);
    }

    void OnColliderEnter(Collision collision)
    {
        Debug.Log("Collide");
        Destroy(gameObject);
    }

    void OnTriggerEnter(Collider collision)
    {
        Destroy(gameObject);
    }
}
