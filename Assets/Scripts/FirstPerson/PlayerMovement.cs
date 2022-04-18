using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Unity.Jobs;

// using Actions;

[RequireComponent(typeof(CharacterController))]
public class PlayerMovement : MonoBehaviour
{

    public static PlayerMovement Instance { set; get; }

    // Invoking Enum Game Mode
    GameMode gameMode;

    // Mouse Look
    MouseLook mouseLook;

    // Jump Action
    Jump jump;

    // Movement Action
    Movement move;

    // Player Audio Class
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
        mouseLook = new MouseLook();

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
            // Start Game. 
            case GameMode.StartGame:

                // Coroutine Function to Start the Game after couple of seconds. 
                StartCoroutine(Start_Game_Coroutine(0.25f));
                break;
            
            // End Game.
            case GameMode.EndGame:
                End_Game();
                break;
        }
    }

    IEnumerator Start_Game_Coroutine(float value)
    {
        yield return new WaitForSeconds(value);
        Start_Game();
    }

    void Start_Game()
    {
        // Player Move Action
        Movement();

        // Player Jump Action
        jump.Execute(Player_Body);
        

        // Quit the Game
        if (Input.GetKeyDown(KeyCode.Escape))
            // Change the Game Mode to End.
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

    void End_Game()
    {
        // Reset the Mouse to the Default Actions.  
        mouseLook.Cursor_Default_Actions();

        // Loading the UI Scene.
        SceneManager.LoadScene(0);
        Application.Quit();
    }
}
