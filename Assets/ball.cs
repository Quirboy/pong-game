using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balls : MonoBehaviour
{
    public float xposition = 0f;
    public float yposition = 0f;
    public float xspeed;
    public float yspeed;
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
    }

    private void OnTriggerEnter2D(Collider2D collision)
{ 
        if (collision.gameObject.CompareTag("horizantalwall"))
        {
            yspeed = yspeed * -1;
            Debug.Log("ColliderErrorState2D entering collision");
        }

        if (collision.gameObject.CompareTag("verticalwall"))
        {
            xspeed = xspeed * -1;
            Debug.Log("ColliderErrorState2D entering collision");
        }
    }
}
