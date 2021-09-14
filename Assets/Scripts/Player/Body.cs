using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Body : MonoBehaviour
{
    
    public PlayerMovement player;
    public CollisionDetection col;
    
    private int faceRight = 0;
    private int faceLeft = 180;

    private bool fliped = false;
    void Start()
    {

       
    }
    void FixedUpdate()
    {
        if (player.horizontalAxis > 0)
        {
            transform.eulerAngles = new Vector2(0, faceRight);
            if (fliped)
            {
                col.flipFront(new Vector2(4.37f, 0));
                fliped = false;
            }
        }


        if (player.horizontalAxis < 0)
        {
            transform.eulerAngles = new Vector2(0, faceLeft);
            if (!fliped)
            {
                col.flipFront(new Vector2(4.37f, 0));
                fliped = true;
            }
        }

      
    }
}
