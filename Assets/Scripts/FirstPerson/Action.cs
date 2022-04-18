using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Jump 
{
    Animator First_Person_Animator;
    Player_Audio player_Audio = new Player_Audio();
    private static bool is_Jump;
    

    public Jump()
    {
        is_Jump = false;
    }

    public void Set_is_Jump(bool value)
    {
        is_Jump = value;
    }

    public bool Get_is_Jump()
    {
        return is_Jump;
    }

    public void Execute(GameObject obj)
    {
        try
        {
            First_Person_Animator = obj.GetComponent<Animator>();
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("Actions::Jump");
                
                // Invoking the Jump Animation and setting it to True.
                First_Person_Animator.SetBool("Jump", true);

                if (First_Person_Animator.GetBool("Jump"))
                {
                    
                    First_Person_Animator.Play("Jump");
                    Set_is_Jump(true);
                }
            }
            if (Input.GetKeyUp(KeyCode.Space))
            {
                First_Person_Animator.SetBool("Jump", false);
                Set_is_Jump(false);
            }
        }
        catch (System.Exception e)
        {
            Debug.LogError("Animator Component not found or Invalid Game Object has been assigned.");
            throw new System.NotImplementedException();
        }
    }
}

public class Movement 
{

    PlayerMovement playerMovement = new PlayerMovement();
    public void Execute(GameObject obj)
    {
        try
        {
        }
        catch (System.Exception e)
        {
            Debug.LogError("");
            throw new System.NotImplementedException();
        }
    }
}


