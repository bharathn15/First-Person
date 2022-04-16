using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using Actions;

public class PlayerMovement : MonoBehaviour
{

    // Invoking Enum Game Mode
    GameMode gameMode;

    Jump jump;
    Movement move;

    Player_Audio player_Audio;




    public CharacterController controller;
    public float Player_Speed = 12f;

    public Vector3 velocity;
    public float gravity = -9.81f;

    public Transform GroundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    public float Jump_Height;

    public bool isGrounded;

    Animator First_Person_Animator;
    public GameObject Player_Body;    

    private void Awake()
    {

        gameMode = GameMode.StartGame;
        

        jump = new Jump();
        move = new Movement();
        player_Audio = new Player_Audio();
    }

    private void Start()
    {
        gravity *= 2;
        Jump_Height = 20f;

        First_Person_Animator = Player_Body.GetComponent<Animator>();
    }

    void Update()
    {
        // Check for the Game Mode.
        // Start Game is default.
        Check_Game_Mode();       
    }

    void Check_Game_Mode()
    {
        switch (gameMode)
        {

            case GameMode.StartGame:
                Start_Game();
                // Debug.Log("Game Has Started.");
                break;
            case GameMode.EndGame:
                End_Game();
                break;
        }
    }

    void Start_Game()
    {
        // Player Move Action
        Movement();

        // Player Jump Action
        jump.Execute(Player_Body);
        Audio_Manager();

        // Quit the Game
        if (Input.GetKeyDown(KeyCode.Escape))
            // Change the Game Mode
            gameMode = GameMode.EndGame;
    }

    void Movement()
    {
        isGrounded = Physics.CheckSphere(GroundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * Player_Speed * Time.deltaTime);


        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }


    // Need to work on this below code.
    void Audio_Manager()
    {
        if(jump.is_Jump == true)
        {
            Debug.Log(jump.is_Jump);
            
            jump.is_Jump = false;
        }
    }

    void End_Game()
    {
        Application.Quit();
        // UnityEditor.EditorApplication.isPlaying = false;
        // Debug.Log("Game Has Ended.");
    }
}
