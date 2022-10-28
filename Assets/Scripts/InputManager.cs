using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public Animator animator;
    private Vector3 movement;
    private float movementSqrMagnitude;
    private GameObject player;

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

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            animator.SetBool("Up", true);
            animator.SetBool("Down", false);
            animator.SetBool("Left", false);
            animator.SetBool("Right", false);
            Debug.Log("Up");
        } else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            animator.SetBool("Down", true);
            animator.SetBool("Up", false);
            animator.SetBool("Left", false);
            animator.SetBool("Right", false);
            Debug.Log("Down");
        } else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            animator.SetBool("Left", true);
            animator.SetBool("Down", false);
            animator.SetBool("Up", false);
            animator.SetBool("Right", false);
            Debug.Log("Left");
        } else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            animator.SetBool("Right", true);
            animator.SetBool("Down", false);
            animator.SetBool("Left", false);
            animator.SetBool("Up", false);
            Debug.Log("Right");
        }
    }

    void GetMovementVector()
    {
        movement.x = Input.GetAxis("Horizontal") * 0.01f;
        movement.y = Input.GetAxis("Vertical") * 0.01f;
        movement = Vector3.ClampMagnitude(movement, 1.0f);
        movementSqrMagnitude = movement.sqrMagnitude;
    }

    void PlayerPosition(GameObject player)
    {
        player.transform.Translate(movement, Space.World);
    }
}
