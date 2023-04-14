using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeHit : MonoBehaviour
{

    public GameObject Sound;
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
    }
}
