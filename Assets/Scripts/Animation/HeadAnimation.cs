using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadAnimation : MonoBehaviour
{
    public PlayerMovement player;
    public Animator anim;
    public GlassesMov glassesMov;
    public GameObject head;
    private Vector3 offsetDre, offsetEsq, originalPos;

    private float rotationHead;

    void Start()
    {
        anim = GetComponentInChildren<Animator>();
        originalPos = transform.localPosition;
        offsetDre = new Vector3(gameObject.transform.localPosition.x-3.5f, gameObject.transform.localPosition.y, gameObject.transform.localPosition.z);
        offsetEsq = new Vector3(gameObject.transform.localPosition.x-3.5f, gameObject.transform.localPosition.y, gameObject.transform.localPosition.z);
    }

    void FixedUpdate()
    {
        rotationHead = glassesMov.getRotz();


        if (player.horizontalAxis != 0)
        {
            anim.SetBool("isMoving", true);
        }
        else
        {
            anim.SetBool("isMoving", false);
        }

        if (head.transform.localScale.y > 0 && player.xAxis < 0)
        {
            transform.localPosition = Vector3.Lerp(transform.localPosition, offsetDre, Time.deltaTime*2f);
                
            Debug.Log("ima down");
        }else if (head.transform.localScale.y < 0 && player.xAxis > 0)
        {
            transform.localPosition = Vector3.Lerp(transform.localPosition, offsetEsq, Time.deltaTime * 3f);
            Debug.Log("ima here");
        }
        else
        {
            transform.localPosition = Vector3.Lerp(transform.localPosition, originalPos, Time.deltaTime * 3f);
        }
        //if (head.transform.localScale.y < 0 && player.xAxis < 0 || head.transform.localScale.y > 0 && player.xAxis > 0)
        //    transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, transform.localPosition.z);


        //if (player.xAxis < 0 && rotationHead > 90)
        //{
        //    Debug.Log("ima here");
        //    transform.position = new Vector3(player.transform.position.x, transform.position.y, transform.position.z);

        //}
    }
}
