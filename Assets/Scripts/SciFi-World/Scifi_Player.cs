using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scifi_Player : MonoBehaviour
{
    [SerializeField] private GameObject Player;
    [SerializeField] private GameObject Player_Position;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        Debug.Log("On Enable Method is working");

        // Position of the Player will be above the SciFi Environment
        Player.transform.Translate(new Vector3(Player_Position.transform.position.x, Player_Position.transform.position.y, Player_Position.transform.position.z));
        //Player.transform.SetPositionAndRotation(new Vector3(Player_Position.transform.position.x, Player_Position.transform.position.y, Player_Position.transform.position.z), Quaternion.identity);
    }
}
