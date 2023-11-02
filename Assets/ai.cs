using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pongBot : MonoBehaviour
{
    //begging speed op bot
    public float ySpeed = 5f;
    //begging position bot
    private float yPosition = 0;
    //calls game object ball
    public GameObject ball;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // the speed of the paddle 
        //updates y position with speed  and multiplued by real time
        yPosition = yPosition + ySpeed * Time.deltaTime;

        //X position is handeld with the current x postion
        transform.position = new Vector3(transform.position.x, ball.transform.position.y / ySpeed, transform.position.z);
        transform.position = new Vector3(transform.position.x, ball.transform.position.y, transform.position.z);

        //checks if the y position is between 3.6 and -3.6
        if (yPosition >= 3.6f)
        {
            ySpeed = ySpeed * -1f;
        }
        else if (yPosition <= -3.6f)
        {
            ySpeed = ySpeed * -1f;
        }

    }
}
