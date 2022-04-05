using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beweeg : MonoBehaviour
{
    public CharacterController2D controller;
    float horizontalMove;float verticalMove;
    public float speed = 40;
    bool jump = false; bool crouch = false;

    // Update is called once per frame
    void Update(){
     horizontalMove = Input.GetAxisRaw("Horizontal") * speed;
     if(Input.GetButtonDown("Jump")){
         jump = true;
     }
     if(Input.GetButtonDown("Crouch")){
         crouch = true;
     }else if (Input.GetButtonUp("Crouch")){
         crouch = false;
     }
 }

    void FixedUpdate(){
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }
}