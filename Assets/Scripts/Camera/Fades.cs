using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fades : MonoBehaviour
{

    public Animator animator;
    public Camera cam;
    
    void Start()
    {
        //GameEvents.current.onCheckpointEnter += Respawn;
    }

    public void Respawn()
    {
        animator.SetTrigger("FadeOut");
    }
    
}
