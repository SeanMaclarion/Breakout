using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{

    public Vector2 startingVelocity = new Vector2(15, -20);
    private Vector3 startingPosition;
    public GameObject gameOverSign;
    public GameObject youWinSign;
    public Text livesValue;
    public Text pointsValue;

    int lives = 3;
    int points = 0;

    // Use this for initialization
    void Start()
    {
        livesValue.text = lives.ToString();

        GetComponent<Rigidbody2D>().velocity = startingVelocity;
        startingPosition = transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -0.25f)
        {
            GetOut();
        }
        if (Input.GetButtonDown("Jump"))
        {
            GetComponent<Rigidbody2D>().velocity = startingVelocity;
        }

    }

    void GetOut()
    {
        Debug.Log("You are out");
        lives--;
        livesValue.text = lives.ToString();
        transform.position = startingPosition;
        GetComponent<Rigidbody2D>().velocity = new Vector2();

        if (lives == 0)
        {
            DoGameOver();
        }
    }

    void DoGameOver()
    {
        gameOverSign.SetActive(true);
    }

    public void YouBrokeABrick()
    {
        points++;
        pointsValue.text = points.ToString();
        var bricksLeft = FindObjectsOfType<Brick>().Length;
        if (bricksLeft == 0)
        {
            youWinSign.SetActive(true);
        }

    }

    public void Teleport()
    {
        transform.position = startingPosition;

    }
    public void SpeedUp()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, -30);


    }
    public void SlowDown()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, -2);
    }
}
