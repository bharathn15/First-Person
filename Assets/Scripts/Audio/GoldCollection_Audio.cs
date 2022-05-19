using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldCollection_Audio : MonoBehaviour
{

    [SerializeField] private AudioSource GoldAudio;
    [SerializeField] private GameObject Scripts;

    [SerializeField] private GameObject Door_Obj;

    Collections collections = new Collections();

    private int Gold_Count;

    private bool is_Gold_Collected;

    void Start()
    {
        Gold_Count = 0;
        is_Gold_Collected = true;
    }

    
    void Update()
    {
        Gold_Collection_Audio();

        Gold_Collected();
    }

    void Gold_Collection_Audio()
    {
        try
        {
            if (collections.get_Gold_Collected() == true)
            {
                // Debug.Log(collections.get_Gold_Collected());
                // Gold Collection Audio. 
                GoldAudio.Play();                
                collections.set_Gold_Collected(false);

                // Debug.Log(Gold_Count);
                Gold_Count += 1;


                
            }
        }
        catch (Exception e)
        {
            Debug.LogError("Gold Collection Audio is not Playing.");
            throw new NotImplementedException();
        }
    }

    void Gold_Collected()
    {
        if (Gold_Count.Equals(6) && is_Gold_Collected )
        {
            Debug.Log(Gold_Count);
            // Scripts.GetComponent<Scifi_Player>().enabled = true;
            Door_Obj.GetComponent<BoxCollider>().enabled = true;
            is_Gold_Collected = false;
        }
    }
}
