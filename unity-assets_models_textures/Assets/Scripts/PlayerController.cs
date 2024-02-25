using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float threshold;
    CharacterController myCharController;

    private float speed = 10f;
    private float jmpFrc = 10f;

    private const float gravity = 25f;

    private Vector3 mvng;

    private float duration = .5f;

    void Start()
    {
        myCharController = GetComponent<CharacterController>();
        mvng = Vector3.zero;   
    }

    void Update()
    {
        mvmnt();
        Rotation();
    }

    void mvmnt()
    {
        if(myCharController.isGrounded)
        {
            mvng = new Vector3(Input.GetAxis("Horizontal"),0f, Input.GetAxis("Vertical"));
            mvng *= speed;
            mvng = transform.rotation * mvng;
            if(Input.GetButton("Jump"))
            {
                mvng.y = jmpFrc;
            }
        }
        mvng.y -= gravity * Time.deltaTime;

        myCharController.Move(mvng * Time.deltaTime);

        if(transform.position.y < threshold)
        {
            transform.position = new Vector3(0f, 25f, 0f);
            
        }
    }



    void Rotation()
    {
        transform.Rotate(new Vector3(0,Input.GetAxis("Mouse X")*2f,0));
    }

   // void FixedUpdate()
   // {
        //if(transform.position.y < threshold)
        //{
            //transform.position = new Vector3(0f, 25f, 0f);
            
        //}
    //}
}
