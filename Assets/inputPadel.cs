using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class inputPaddle : MonoBehaviour
{
    public float speed = 3f;
    public string leftOrRight;

    
    void setKeyAndMovement(KeyCode up, KeyCode down)
    {
        if (Input.GetKey(up) && transform.position.y <= 3.6f)
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        else if (Input.GetKey(down) && transform.position.y >= -3.6f)
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
    }

    
    void Update()
    {
      
        if (leftOrRight == " left ")
        {
            setKeyAndMovement(KeyCode.W, KeyCode.S);
        }
        else if (leftOrRight == " right ")
        {
            setKeyAndMovement(KeyCode.UpArrow, KeyCode.DownArrow);
        }

    }
}