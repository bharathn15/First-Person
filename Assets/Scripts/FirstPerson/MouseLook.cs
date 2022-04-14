using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{

    public Transform playerBody;

    float xRotation = 0f;
    float yRotation = 0f;

    public float Mouse_Senesitivity = 100f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
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
