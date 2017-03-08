using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DurableBrick : MonoBehaviour
{
    int hits = 3;
    // Use this for initialization
    void Start()
    {

    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        hits--;
        if (hits == 0)
        {
            gameObject.SetActive(false);
        }
    }
}
