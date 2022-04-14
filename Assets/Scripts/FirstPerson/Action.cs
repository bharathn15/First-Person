using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : Command
{
    Animator First_Person_Animator;

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
                }
            }
            if (Input.GetKeyUp(KeyCode.Space))
            {
                First_Person_Animator.SetBool("Jump", false);
            }
        }
        catch (System.Exception e)
        {
            Debug.LogError("Animator Component not found or Invalid Game Object has been assigned.");
            throw new System.NotImplementedException();
        }
    }
}


public class Movement : Command
{
    public void Execute(GameObject obj)
    {
        try
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                Debug.Log("W Key has been pressed.");
            }
        }
        catch (System.Exception e)
        {
            Debug.LogError("");
            throw new System.NotImplementedException();
        }
    }
}


