using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

    public float ForwardSpeed = 10;
    public float LRSpeed = 5;
    public float gravity = -8f;
    public float jumpSpeed = 2;

    private float vertSpeed;
    private Vector3 movement;
    CharacterController charController;
    [SerializeField] private Animator animator;

	// Use this for initialization
	void Start () {
        charController = GetComponent<CharacterController>();
    }
	
	// Update is called once per frame
	void Update () {
        //get Input
        float horInput = Input.GetAxis("Horizontal")*LRSpeed*Time.deltaTime;
        float vertInput = Input.GetAxis("Vertical")* ForwardSpeed * Time.deltaTime;

        //jumping
        if (charController.isGrounded)
        {
            vertSpeed = 0;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                vertSpeed = jumpSpeed;
            }
        }

        vertSpeed += gravity * Time.deltaTime;

        //walking animation
        if(vertInput > 0.01 || vertInput < -0.01)
        {
            animator.SetBool("isWalking", true);
        }
        else
        {
            animator.SetBool("isWalking", false);
        }

        movement = new Vector3(horInput, vertSpeed, vertInput);
        movement = transform.TransformDirection(movement);
        charController.Move(movement);
	}
}
