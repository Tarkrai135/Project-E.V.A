using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Furro : ObjectClass
{
    
    public float velocity = 2;
    public Transform player;
    public ConeDetect cone;
    public  bool active = false;
    private Vector3 mov = Vector3.zero;
    private float distance = 0;
    private bool fall = false;
    private Rigidbody2D rigidBody;
    private FurroAnimation furroAnim;
    private bool fliped = false;
    public bool playerDied;
    private bool furroAlert;



    new void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        furroAnim = GetComponent<FurroAnimation>();
        playerDied = false;
        furroAlert = true;
        base.Start();
        
    }

    void FixedUpdate()
    {
        moveFurro();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Glasses"))
        {
            cone.isFurro(true);
            cone.setTarget(gameObject);
            if (furroAlert)
            {
                FindObjectOfType<AudioManager>().Play("FurroConeDetect");
                furroAlert = false;
            }
            
        }

    }

    public void willFall()
    {
        fall = true;
    }
    public void willNotFall()
    {
        fall = false;
    }
    public void moveFurro()
    {
        if (active)
        {
            if (playerDied) return;

            distance = player.position.x - transform.position.x;
            if (Mathf.Abs(distance) > 0)
                {
                    if (player.position.x < transform.position.x)
                    {
                        flipESQ();
                        if(!fall) mov = new Vector3(-velocity, 0, 0);
                        else mov = Vector3.zero;
                        furroAnim.anim.SetBool("isFollowing", true);
                    }
                    else
                    {
                        flipDER();
                        if (!fall) mov = new Vector3(velocity, 0, 0);
                        else mov = Vector3.zero;
                        furroAnim.anim.SetBool("isFollowing", true);
                    }
                }
            transform.position += (mov * Time.deltaTime);
        }
        else
        {
            rigidBody.velocity = Vector3.zero;
            furroAnim.anim.SetBool("isFollowing", false);
            furroAlert = true;
        }
    }
    private void flipDER()
    {
        transform.eulerAngles = new Vector2(0, 0);
        fliped = false;
    }
    private void flipESQ()
    {
        transform.eulerAngles = new Vector2(0, 180);
        fliped = true;

    }
    public bool isFliped()
    {
        return fliped;
    }
    public void setActive(bool watching)
    {
        active = watching;
    }
    public void killPlayer()
    {
         
        playerDied = true;
        active = false;
       
    }
    public void revivePlayer()
    {
        playerDied = false;
    }
    public void freeze()
    {
        gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
    }
    public void unFreeze()
    {
        gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
    }
}
