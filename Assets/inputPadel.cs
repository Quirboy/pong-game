using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class inputPaddle : MonoBehaviour
{
    // setting the speed of the padle
    public float speed = 3f;
    //checks if it is right or left padle 
    // has to change in unity
    public string leftOrRight;

    /// <summary>
    /// function that handles movement and has variables for up and down keycode?
    /// </summary>
    /// <param name="up">key that is handeling up input</param>
    /// <param name="down">key that is handeling down inpu </param>
    void setKeyAndMovement(KeyCode up, KeyCode down)
    {
        //when up key is pressed/hold
        if (Input.GetKey(up) && transform.position.y <= 3.6f)
        {
            //translate works with new vector 3 and
            //it,s changing with vector 3 up multiplied with speed and time.deltatime
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        else if (Input.GetKey(down) && transform.position.y >= -3.6f)
        {
            //same but then with vector 3 down
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Change within Unity if it's left or the right paddle
        if (leftOrRight == "left")
        {
            setKeyAndMovement(KeyCode.W, KeyCode.S);
        }
        else if (leftOrRight == "right")
        {
            setKeyAndMovement(KeyCode.UpArrow, KeyCode.DownArrow);
        }

    }
}