using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class balls : MonoBehaviour
{
    public float xposition = 0f;
    public float yposition = 0f;
    public float xspeed;
    public float yspeed;
    public TMP_Text scorefield;
    private int leftscore = 0;
    private int rightscore = 0;
    public int topscore = 10;

    private void resetball (string leftOrRight) 
    {
        xposition = 0f;
        yposition = 0f;
        scorefield.text = leftscore + "-" + rightscore;
        if(leftOrRight == "left")
        {
            xspeed = 3f;
            yspeed = 3f;
        }
        else if (leftOrRight == "right")
        {

            xspeed = -3f;
            yspeed = 3f;
        }

    }
    // Start is called before the first frame update
    void Start()

    {

        transform.position = new Vector3(xposition, yposition, 0);

        xspeed = 1f;
        yspeed = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        xposition += xspeed * Time.deltaTime;
        yposition += yspeed * Time.deltaTime;
        transform.position = new Vector3(xposition, yposition, 0);

        if (leftscore >= topscore) 
        {
            scorefield.text = "leftplayer has won";
 
            xspeed = 0f;
            yspeed = 0f;
        }
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("horizantalwall"))
        {
            yspeed = yspeed * -1f;
            
        }

        if (collision.gameObject.CompareTag("leftwal"))
        {
            rightscore++;
            resetball("left");
        }

        if (collision.gameObject.CompareTag("rightwal"))
        {
            leftscore++; 
            resetball("right");    
        }
        if (collision.gameObject.CompareTag("Player"))
        {
            xspeed = xspeed * -1.2f;

        }
    }

}