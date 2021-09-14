using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDetectUs : MonoBehaviour
{

    public Transform transformToFollow;
    //private bool inRadius = false;
    private float dis = 0;

    [SerializeField]
    public float RadiusDetect;

    void Update()
    {


        dis = transform.position.magnitude + transformToFollow.position.magnitude;
        if (!(dis > RadiusDetect && (transformToFollow.position.x <0f || transformToFollow.position.x>10f)))
        {
            transform.right = transform.position - transformToFollow.position;

            RaycastHit2D rh = Physics2D.Raycast(transform.position, transformToFollow.transform.position - transform.position, (transformToFollow.transform.position - transform.position).magnitude);
            Debug.DrawRay(transform.position, transformToFollow.position - transform.position, Color.green);

            Debug.Log("DETECTED");
        }
        else{
            Debug.Log("NO DETECTED");
        }
    }
}
