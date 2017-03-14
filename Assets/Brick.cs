using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    public int health = 1;
    public bool isTeleport = false;
    public bool isSpeed = false;
    public bool isSlow = false;
    // Use this for initialization
    void Start()
    {

    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        health--;
        if (isTeleport == true)
        {
            FindObjectOfType<Ball>().Teleport();
        }
        if (isSpeed == true)
        {
            FindObjectOfType<Ball>().SpeedUp();
        }
        if (isSlow == true)
        {
            FindObjectOfType<Ball>().SlowDown();
        }
        if (health == 0)
        {
            gameObject.SetActive(false);
            FindObjectOfType<Ball>().YouBrokeABrick();
        }
      
    }
}