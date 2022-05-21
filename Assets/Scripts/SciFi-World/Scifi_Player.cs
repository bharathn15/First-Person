using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scifi_Player : MonoBehaviour
{
    [SerializeField] private GameObject Player;
    [SerializeField] private GameObject Player_Position;

    [SerializeField] private GameObject Green_World;
    [SerializeField] private GameObject Scifi_World;

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
        // Player.transform.Translate(new Vector3(Player_Position.transform.position.x, Player_Position.transform.position.y, Player_Position.transform.position.z));
        Player.transform.position = new Vector3(Player_Position.transform.position.x, Player_Position.transform.position.y, Player_Position.transform.position.z);

        Green_World.SetActive(false);
        Scifi_World.transform.position = new Vector3(Green_World.transform.position.x, Green_World.transform.position.y, Green_World.transform.position.z);

    }
}
