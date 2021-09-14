using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyAnimation : MonoBehaviour
{
    public PlayerMovement player;
    public Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();

    }

    void FixedUpdate()
    {
        if (player.horizontalAxis != 0)
        {
            anim.SetBool("isMoving", true);
        }
        else
        {
            anim.SetBool("isMoving", false);
        }
    }
}
