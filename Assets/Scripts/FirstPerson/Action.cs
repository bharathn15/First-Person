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
                // Debug.Log("Actions::Jump");
                
                // Invoking the Jump Animation and setting it to True.
                First_Person_Animator.SetBool("Jump", true);

                if (First_Person_Animator.GetBool("Jump"))
                {
                    
                    First_Person_Animator.Play("Jump");
                    
                    // If Jump is true 
                    // Jump Audio will be Played
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

public class First_Person_Camera
{
    bool is_FirstPerson_Enabled;

    public First_Person_Camera()
    {
        is_FirstPerson_Enabled = false;
    }

    public void Set_FirstPerson_Camera(bool value)
    {
        is_FirstPerson_Enabled = value;
    }

    public bool Get_FirstPerson_Camera()
    {
        return is_FirstPerson_Enabled;
    }
    public void Execute(GameObject obj)
    {
        try
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                Set_FirstPerson_Camera(true);
                if(Get_FirstPerson_Camera() == true)
                {
                    obj.GetComponent<Animation>().Play("FirstPerson_Camera");
                }
            }
        }
        catch (System.Exception e)
        {
            Debug.Log("Main Camera Game Object is not found in the Hierarchy.");
        }   
    }
}

public class Third_Person_Camera
{
    // Animator is not using 
    Animator ThirdPersonCamera;
    bool is_ThirdPerson_Enabled;

    public Third_Person_Camera()
    {
        is_ThirdPerson_Enabled = false;
    }

    public void Set_ThirdPerson_Camera(bool value)
    {
        is_ThirdPerson_Enabled = value;
    }

    public bool Get_ThirdPerson_Camera()
    {
        return is_ThirdPerson_Enabled;
    }


    public void Execute(GameObject obj)
    {
        try
        {
            // ThirdPersonCamera = obj.GetComponent<Animator>();
            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                Set_ThirdPerson_Camera(true);
                if(Get_ThirdPerson_Camera() == true)
                {
                    obj.GetComponent<Animation>().Play("ThirdPerson_Camera");
                }
            }
        }
        catch(System.Exception e)
        {
            Debug.Log("Main Camera Game Object is not found in the Hierarchy.");
        }
    }
}



