using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
   
    private void Start()
    {
        
    }

    public void Start_Game()
    {
        SceneManager.LoadScene(1);
        // Debug.Log("Start Game method is working.");
    }
}
