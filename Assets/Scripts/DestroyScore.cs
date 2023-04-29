using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyScore : MonoBehaviour
{
    void Update()
    {
        Destroy(gameObject, 2);
    }
}
