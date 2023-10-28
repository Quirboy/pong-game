using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonScript : MonoBehaviour
{
   public void startOnePlayer()
    {
        SceneManager.LoadScene("pongPlayerOne");
    }
    public void startTwoPlayer()
    {
        SceneManager.LoadScene("pongTwoPlayers");
    }

    public void QuiteGame() 
    {
    Application.Quit();  
    }
}