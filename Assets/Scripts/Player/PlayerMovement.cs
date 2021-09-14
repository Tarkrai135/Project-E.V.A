using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;

public class PlayerMovement : MonoBehaviour
{
    public float Speed = 4f;
    public HeadAnimation head;
    public BodyAnimation body;
    private GameObject inputsAndButtons;
    private Inputs input;
    public float horizontalAxis;
    public bool freeze;
    public CollisionDetection col;
    
    public float xAxis { get { return horizontalAxis; } }

    private Rigidbody2D rb;
    private bool playerKilled = false;
    private Vector2 moveKey;
    private void Awake()
    {
        inputsAndButtons = GameObject.Find("InputsAndButtons");
        input = inputsAndButtons.GetComponent<Inputs>();
    }
    private void FixedUpdate()
    {
        if (!playerKilled)
        {
            movePlayer();
        }
        if (freeze)
        {
            //rb.isKinematic = true;
            //rb.velocity = Vector3.zero;
            Speed = 0;
        }
        else
        {
            Speed = 4;
        }
       
    }
    public void killPlayer()
    {
        playerKilled = true;
    }
    public void revivePlayer()
    {
        playerKilled = false;
    }
    public bool isKilled()
    {
        return playerKilled;
    }
    public void movePlayer()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.freezeRotation = true;
        if (input.isMouseKeyboard())
        {
            moveKey = input.getMoveKeyboard();
        }
        else
        {
            moveKey = input.getMoveGamepad();
        }
        if (col.getCheckfrontFliped() == false && moveKey.x > 0 && col.getIsTouchingFront()) moveKey = Vector2.zero;
        if (col.getCheckfrontFliped() == true && moveKey.x < 0 && col.getIsTouchingFront()) moveKey = Vector2.zero;
        Vector2 vel = rb.velocity;
        horizontalAxis = moveKey.x;
        vel.x = horizontalAxis * Speed;
        rb.velocity = vel;
    }


}
