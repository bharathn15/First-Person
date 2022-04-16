using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{

    StartButton startButton;

    public Transform playerBody;

    float xRotation = 0f;
    float yRotation = 0f;

    public float Mouse_Senesitivity = 100f;

    void Start()
    {

        startButton = new StartButton();

        Cursor_Actions();
    }


    void Cursor_Actions()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        startButton.setStart_Button_Value(false);
    }

    void Update()
    {

        float MouseX = Input.GetAxis("Mouse X") * Time.deltaTime * Mouse_Senesitivity;
        float MouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * Mouse_Senesitivity;

        xRotation -= MouseY;
        xRotation = Mathf.Clamp(xRotation, -75f,80f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * MouseX);
    }
}
