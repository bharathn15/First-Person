using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screen_Pointer : MonoBehaviour
{

    [SerializeField] private Transform Main_Camera;

    private void Awake()
    {
        
    }

    void Start()
    {
        
    }

  
    void Update()
    {
        Draw_Point();
    }

    void Draw_Point()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        
        if(Physics.Raycast(ray, out hit))
        {
            // Debug.DrawLine();
            float X_Pos = Main_Camera.position.x; //  / 2;
            float Y_Pos = Main_Camera.position.y; //  / 2;
            float Z_Pos = Main_Camera.position.z;
            // Debug.Log(X_Pos);
            // Debug.Log(Y_Pos);
            Debug.DrawLine(new Vector3(X_Pos,Y_Pos, Z_Pos), new Vector3(X_Pos+2f, Y_Pos+2f, Z_Pos+2f), Color.red);
            // Debug.Log(hit.collider.gameObject.name);
        }
    }

}
