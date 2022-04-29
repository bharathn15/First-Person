using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldCollection_Audio : MonoBehaviour
{

    [SerializeField] private AudioSource GoldAudio;

    Collections collections = new Collections();

    void Start()
    {
        
    }

    
    void Update()
    {
        Gold_Collection_Audio();   
    }

    void Gold_Collection_Audio()
    {
        try
        {
            if (collections.get_Gold_Collected() == true)
            {
                Debug.Log(collections.get_Gold_Collected());
                // Gold Collection Audio.
                GoldAudio.Play();                
                collections.set_Gold_Collected(false);
            }
        }
        catch (Exception e)
        {
            Debug.LogError("Gold Collection Audio is not Playing.");
            throw new NotImplementedException();
        }
    }
}
