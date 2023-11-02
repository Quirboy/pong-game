using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class balls : MonoBehaviour
{
    //<summary>
    // settings for the ball
    // move in x and y direction
    //change cource when it hit something
    // scorering ball hits left or right wall
    //showing score in textfield
    // when ball hits paddle it speeds up
    //<summary>

    //position x and y
    public float xposition = 0f;
    public float yposition = 0f;
    //speed x and y
    public float xspeed;
    public float yspeed;
    //refrence the text object
    public TMP_Text scorefield;
    //keeping left and right score
    private int leftscore = 0;
    private int rightscore = 0;
    // if top score is met game stop
    public int topscore = 10;


    //function for reset ball
    private void resetball (string leftOrRight) 
    {
        // starting possition
        xposition = 0f;
        yposition = 0f;
        //displays score in text field
        scorefield.text = leftscore + "-" + rightscore;
        //checks argument from the function left or right typed in
        if(leftOrRight == "left")
        {
            //ball goes right and up
            xspeed = 3f;
            yspeed = 3f;
        }
        else if (leftOrRight == "right")
        {
            //ball goes left and up
            xspeed = -3f;
            yspeed = -3f;
        }

    }
    // Start is called before the first frame update
    void Start()

    {
        //ball start
        transform.position = new Vector3(xposition, yposition, 0);
        // speed of the ball at the beginning
        xspeed = 5f;
        yspeed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        //updates the possition and speed
        //so ball not moving on frame rate but time so same speed every device
        xposition += xspeed * Time.deltaTime;
        yposition += yspeed * Time.deltaTime;
        transform.position = new Vector3(xposition, yposition, 0);
        //updates with new values

        // if top score is hit on the left side left has won and the game stops and put the 
        //ball in the middel
        if (leftscore >= topscore) 
        {
            scorefield.text = "leftplayer has won";
 
            xspeed = 0f;
            yspeed = 0f;
        }
        // if top score is hit on the right side right has won
        else if (rightscore >= topscore) 
        {
            scorefield.text = "rightplayer has won";

            xspeed = 0f;
            yspeed = 0f;
        }
    }


    //if it hit a gameobject with a collider and that is set on a trigger it does something
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if gameobject has a tag that matches with the wall
        // and it has a collider on it set to trigger
        if (collision.gameObject.CompareTag("horizantalwall"))
        {
            //flipps direction vertical from up to down
            yspeed = yspeed * -1f;
            
        }

        if (collision.gameObject.CompareTag("leftwal"))
        {
            //adds 1 to score and triggers reset function with left argumment
            rightscore++;
            resetball("left");
        }
        //if you score you reset the ball 
        if (collision.gameObject.CompareTag("rightwal"))
        {
            //see above
            leftscore++; 
            resetball("right");    
        }
        if (collision.gameObject.CompareTag("Player"))
        {
            //if it hits a paddle it flips the horizontal and increace with 10 percent
            xspeed = xspeed * -1f;

        }
    }

}