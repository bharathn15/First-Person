using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Input_Settings : MonoBehaviour
{
    // MouseLook class
    MouseLook mouseLook;

    bool is_Settings_Opened;

    public Input_Settings()
    {
        is_Settings_Opened = false;
    }

    public void Set_is_Settings_Opened(bool value)
    {
        is_Settings_Opened = value;
    }

    public bool Get_is_Settings_Opened()
    {
        return is_Settings_Opened;
    }

    private void Awake()
    {
        mouseLook = new MouseLook();
    }

    void Start()
    {
        
    }

    
    void Update()
    {
        // Open and Close of the Settings tab.
        Settings();
    }

    void Settings()
    {

        // Left Mouse Click to show up cursor
        if (Input.GetMouseButtonDown(0)) //  && Get_is_Settings_Opened() == false
        {
            Debug.Log("Settings menu Opened.");

            // Reset the Mouse to default actions
            mouseLook.Cursor_Default_Actions();
           // Set_is_Settings_Opened(true);
        }

        // Right Mouse Click to hide the cursor.
        if (Input.GetMouseButtonDown(1)) // && Get_is_Settings_Opened() == true
        {
            Debug.Log("Settings menu Closed.");

            // Hide the Cursor Arrow.
            mouseLook.Cursor_Actions();
            Set_is_Settings_Opened(false);
        }


    }
}
