using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Head : MonoBehaviour
{
    public GlassesMov glassesMov;
    public PlayerMovement player;
    

    private float rotationHead;
    private Vector3 offsetHeadRight, offsetHeadLeft, initPos;


    private void Start()
    {
        offsetHeadRight = new Vector3(transform.position.x + 1, transform.position.y, transform.position.z);
        offsetHeadLeft = new Vector3(transform.position.x - 1, transform.position.y, transform.position.z);
        initPos = new Vector3(transform.position.x, transform.position.y, transform.position.z);

    }
    void FixedUpdate()
    {
        rotationHead = glassesMov.getRotz();

        if (rotationHead > 90 || rotationHead < -90) flip();
        else normal();

        transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, rotationHead);

        

        //if (rotationHead < 90 && player.xAxis < 0)
        //{
        //    //Debug.Log("yii");
        //    //transform.position = new Vector3(transform.position.x - var, transform.position.y, transform.position.z);
        //    var = -0.3f;
        //}
        //if (rotationHead > 45 && player.xAxis > 0)
        //{
        //    //Debug.Log("y00");
        //    //transform.position = new Vector3(transform.position.x + var, transform.position.y, transform.position.z);
        //    var = 0.3f;
        //}

        ////transform.position = new Vector3(player.transform.position.x + var, transform.position.y, transform.position.z);
        //var = 0;

        ////if (player.xAxis < 0 && rotationHead > 90)
        ////{
        ////    Debug.Log("ima here");
        ////    transform.position = new Vector3(player.transform.position.x, transform.position.y, transform.position.z);

        ////}



    }
    public void flip()
    {
        transform.localScale = new Vector3(transform.localScale.x, -1, transform.localScale.z);
    }
    public void normal()
    {
        transform.localScale = new Vector3(transform.localScale.x, 1, transform.localScale.z);
    }
}

