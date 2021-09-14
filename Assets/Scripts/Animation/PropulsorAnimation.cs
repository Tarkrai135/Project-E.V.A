using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropulsorAnimation : MonoBehaviour
{
    public Animator anim;
    public PlayerMovement player;

    void Start()
    {
        anim = GetComponent<Animator>();
    }


    void FixedUpdate()
    {

        if (player.horizontalAxis != 0)
        {
            anim.SetBool("IsMoving", true);
        }
        else
        {
            anim.SetBool("IsMoving", false);
        }

    }
}
