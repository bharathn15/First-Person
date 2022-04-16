using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour
{
    bool isGame_Started;

    private void Start()
    {
        isGame_Started = false;
        //Debug.Log(isGame_Started);
    }

    public void setStart_Button_Value(bool value)
    {
        isGame_Started = value;
    }

    public bool getStart_Button_Value()
    {
        return isGame_Started;
    }
    public void Start_Game()
    {
        setStart_Button_Value(true);
        Debug.Log(isGame_Started);
    }
}
