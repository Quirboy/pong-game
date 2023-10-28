using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class pongai : MonoBehaviour
{
    public float yspeed = 3f;
    public float ypostion = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ypostion = ypostion + yspeed * Time.deltaTime;
        transform.position= new Vector3(transform position.x, ypostion,transform.position.z);
    }
}
