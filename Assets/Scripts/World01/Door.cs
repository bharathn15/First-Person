using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{

    [SerializeField] private GameObject Player;
    [SerializeField] private GameObject Player_Position;

    private void Awake()
    {
        this.GetComponent<BoxCollider>().enabled = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Equals("First_Person"))
        {
            Debug.Log("Player has collided with the Door.");
            // Player.transform.position = new Vector3(Player_Position.transform.position.x, Player_Position.transform.position.y, Player_Position.transform.position.z);
            Vector3.MoveTowards(Player.transform.position, Player_Position.transform.position, Time.deltaTime * 10);
            // Player.transform.SetPositionAndRotation(new Vector3(0, 0, 0), Quaternion.identity);
            
            Debug.Log(Player.transform.position.x);
            Debug.Log(Player.transform.position.y);
            Debug.Log(Player.transform.position.z);
            // Player.transform.SetPositionAndRotation(new Vector3(0, 0, 0), Quaternion.identity);

        }
    }
}
