using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Audio : MonoBehaviour
{

    public static Player_Audio Instance { set; get; }

    Jump jump;
    Collections collections;

    // Order of Audio Source.
    public AudioSource[] Audio;

    public Player_Audio()
    {
        
    }

    private void Awake()
    {
        jump = new Jump();
        collections = new Collections();
    }

    void Start()
    {
        
    }

    
    void Update()
    {
        // Jumping Audio
        Jump_Audio();
    }

    void Jump_Audio()
    {
        try
        {
            if (jump.Get_is_Jump())
            {
                // Jump Audio.
                Audio[0].Play();

                // Setting the Jump to False.
                jump.Set_is_Jump(false);
            }
        }
        catch (Exception e)
        {
            Debug.LogError("Jump Audio is not Playing.");
            throw new NotImplementedException();
        }   
    }
}
