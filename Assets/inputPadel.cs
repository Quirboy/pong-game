using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.VisualScripting;
using UnityEngine;

public class inputPadel : MonoBehaviour
{
    public float speed = 3f;
    public string leftOrRight;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (leftOrRight == "Left") 
        {
            if (Input.GetKey(KeyCode.W))
            {
             transform.Translate(Vector3.up * speed * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.S))
            {
             transform.Translate(Vector3.down * speed * Time.deltaTime);
            }
        }
        else if(leftOrRight == "Right")
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
             transform.Translate(Vector3.up * speed * Time.deltaTime);
             

            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {

              transform.Translate(Vector3.down * speed * Time.deltaTime);
            }
        }
    } 
}
