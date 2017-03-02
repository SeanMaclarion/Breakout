using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

   public Vector2 startingVelocity = new Vector2(15, -20);

	// Use this for initialization
	void Start ()
    {
        GetComponent<Rigidbody2D>().velocity = startingVelocity;
	}
	// Update is called once per frame
	void Update ()
    {
        if (transform.position.y < -0.3f)
        {
            GetOut();
        }
    }

    void GetOut()
    {
        Debug.Log("You are out");
    }
}
