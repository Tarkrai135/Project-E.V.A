using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FurroAnimation : MonoBehaviour
{
    // Start is called before the first frame update
    

    public Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       
    }
}
