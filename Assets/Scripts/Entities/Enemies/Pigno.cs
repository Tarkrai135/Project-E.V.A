using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pigno : ObjectClass
{

    public float velocity = 2;
    public Transform player;
    public ConeDetect cone;
    public Animator pignoAnim;
    public bool playerDied;

    public bool active = true;
    private Vector3 mov = Vector3.zero;
    private float distanceX = 0;
    private float distanceY = 0;
    private bool fall = false;
    private Rigidbody2D rigidBody;
    
    
    private bool fliped = false;
    private bool pignoAlert;

    new void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        playerDied = false;
        pignoAlert = true;
        base.Start();

    }

    void FixedUpdate()
    {
        movePigno();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Glasses"))
        {
            cone.isFurro(false);
            cone.setTarget(gameObject);
            if (pignoAlert)
            {
                FindObjectOfType<AudioManager>().Play("PignoConeDetect");
                pignoAlert = false;
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
    public void movePigno()
    {

        if (active)
        {
            if (playerDied) return;
            distanceX = player.position.x - transform.position.x;
            distanceY = player.position.y - transform.position.y;

            if (Mathf.Abs(distanceX) < 8 && Mathf.Abs(distanceY) < 2)
            {
                pignoAnim.SetBool("isStatic", true);
                if (player.position.x < transform.position.x)
                {
                    flipDER();
                    if (!fall) mov = new Vector3(-velocity, 0, 0);
                    else mov = Vector3.zero;
                    pignoAnim.SetBool("isFollowing", true);
                }
                else
                {
                    flipESQ();
                    if (!fall) mov = new Vector3(velocity, 0, 0);
                    else mov = Vector3.zero;
                    pignoAnim.SetBool("isFollowing", true);
                }
            }
            else
            {
                 mov = Vector3.zero;
                 pignoAnim.SetBool("isStatic", false);
                 pignoAlert = true;
            }
           
            transform.position += (mov * Time.deltaTime);
            
        }
        else
        {
            
            rigidBody.velocity = Vector3.zero;
            pignoAnim.SetBool("isFollowing", false);

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
        pignoAnim.SetTrigger("Atac");
        playerDied = true;
        active = false;
    }
    public void revivePlayer()
    {
        playerDied = false;
        active = true;
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
