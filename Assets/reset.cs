using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reset : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        GameManager gameManager = FindObjectOfType<GameManager>();
        Bal bal = other.gameObject.GetComponent<Bal>();

        if (gameManager != null)
        {
            gameManager.Miss();
        }
        else if (bal != null)
        {
            bal.ResetBall();
        }
    }

}
