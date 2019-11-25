
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //instansiate charcter controller component
    private CharacterController character_Controller;

    private Vector3 move_Direction;
    //how fast chara moves 
    public float speed = 5f;
    //how fast chara falls
    private float gravity = 20f;

    public float jump_Force = 10f;
    private float vertical_Velocity;

    void Awake()
    {
        //gets character controller
        character_Controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        MoveThePlayer();
    }
    void MoveThePlayer()
    {
        //moves on y and x
        move_Direction = new Vector3(Input.GetAxis("Horizontal"), 0f,  Input.GetAxis("Vertical"));



        move_Direction = transform.TransformDirection(move_Direction);
        move_Direction *= speed * Time.deltaTime;

        ApplyGravity();
        //moves character controller
        character_Controller.Move(move_Direction);


    } 



    void ApplyGravity()
    {
        //speed of falling 
        vertical_Velocity -= gravity * Time.deltaTime;
        PlayerJump();

        move_Direction.y = vertical_Velocity * Time.deltaTime;

    } 

    void PlayerJump()
    {

        if (character_Controller.isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            vertical_Velocity = jump_Force;
        }

    }

}
