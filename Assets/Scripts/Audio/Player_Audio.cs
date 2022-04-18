using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Audio : MonoBehaviour
{

    // public static Player_Audio Instance { set; get; }

    Jump jump;

    public AudioSource jumpAudio;


    public Player_Audio()
    {
        
    }

    private void Awake()
    {
        jump = new Jump();
    }

    void Start()
    {
        
    }

    
    void Update()
    {
        if (jump.Get_is_Jump())
        {
            Jump_Audio();
            jump.Set_is_Jump(false); 
        }    
    }

    void Jump_Audio()
    {
        try
        {
            jumpAudio.GetComponent<AudioSource>().Play();
        }
        catch (Exception e)
        {
            Debug.LogError("Jump Audio is not Playing.");
            throw new NotImplementedException();
        }
        
    }


}
