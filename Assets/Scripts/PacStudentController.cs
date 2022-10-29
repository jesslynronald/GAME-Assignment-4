using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacStudentController : MonoBehaviour
{
    public Animator animator;
    private Vector3 movement;
    private float movementSqrMagnitude;
    private GameObject player;
    private string lastInput;
    private string currentInput;
    private string playerInput = "";

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        GetMovementVector();
        PlayerPosition(player);

        if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetBool("Up", true);
            animator.SetBool("Down", false);
            animator.SetBool("Left", false);
            animator.SetBool("Right", false);
            lastInput = "W";            
        } else if (Input.GetKeyDown(KeyCode.S))
        {
            animator.SetBool("Down", true);
            animator.SetBool("Up", false);
            animator.SetBool("Left", false);
            animator.SetBool("Right", false);
            lastInput = "S";
        } else if (Input.GetKeyDown(KeyCode.A))
        {
            animator.SetBool("Left", true);
            animator.SetBool("Down", false);
            animator.SetBool("Up", false);
            animator.SetBool("Right", false);
            lastInput = "A";
        } else if (Input.GetKeyDown(KeyCode.D))
        {
            animator.SetBool("Right", true);
            animator.SetBool("Down", false);
            animator.SetBool("Left", false);
            animator.SetBool("Up", false);
            lastInput = "D";           
        }
        // Debug.Log(lastInput);
    }

    void GetMovementVector()
    {
        movement.x = Input.GetAxis("Horizontal") * 0.07f;
        movement.y = Input.GetAxis("Vertical") * 0.07f;
        movement = Vector3.ClampMagnitude(movement, 1.0f);
        movementSqrMagnitude = movement.sqrMagnitude;
    }

    void PlayerPosition(GameObject player)
    {
        player.transform.Translate(movement, Space.World);
    }
}
