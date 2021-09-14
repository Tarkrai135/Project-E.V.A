using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassesBounc : MonoBehaviour
{

    public Animator headanim;
    public GlassesMov glasses;
    public bool LookingRight;
    public GameObject head;
    public PlayerMovement player;

    private Animator lightAnim;
    private Quaternion rot;
    private Vector3 posRight, posLeft, originalPos;

    void Start()
    {
        lightAnim = GetComponent<Animator>();
        lightAnim.SetBool("IsIdle", true);

        rot = transform.rotation;


    }
    void Update()
    {

        if (headanim.GetCurrentAnimatorStateInfo(0).IsName("Head_Idle"))
        {
            lightAnim.SetBool("IsIdle", true);
        }
        else
        {
            lightAnim.SetBool("IsIdle", false);
        }



        if (head.transform.localScale.y > 0)
        {
            lightAnim.SetBool("SwitchSide", true);
            transform.localRotation = Quaternion.Euler(new Vector3(0f, 0f, -90f));
            
        }
        else if (head.transform.localScale.y < 0)
        {
            lightAnim.SetBool("SwitchSide", false);
            transform.localRotation = Quaternion.Euler(new Vector3(-180f, 0f, -90f));
        }
        
       



    }

    //float floatSpan = 2f;
    //public float speed = 5.83f;

    //private float startY;

    //void Start()
    //{
    //    startY = transform.localPosition.y;
    //}

    //void Update()
    //{
    //    transform.localPosition = new Vector3(transform.localPosition.x, startY + Mathf.Sin(Time.time * speed) * floatSpan / 2.0f, transform.localPosition.z);
    //}
}
