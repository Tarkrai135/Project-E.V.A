using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    public HeadAnimation head;
    public BodyAnimation body;
    public GameObject glasses;
    public CollisionDetection collisionDetection;
    public CameraManager cam;
    public State state;
    public TreasureManager treasureManager;
    public Animator pignoAnim;
    private Pigno pigno;
    private Furro furro;

    public GameObject killer;
    public GameObject player;
    private Rigidbody2D rb;
    private Collider2D cuerpo;
    private void Start()
    {
        collisionDetection = GetComponent<CollisionDetection>();
        GameEvents.current.onCheckpointEnter += Respawn;
        cuerpo = player.GetComponent<BoxCollider2D>();

    }
    private void FixedUpdate()
    {
        rb = player.GetComponent<Rigidbody2D>();
        if (collisionDetection.isTouchingEnemy == true)
        {
            
            FindObjectOfType<AudioManager>().Play("Death");
            GameEvents.current.CheckPointStarted();

            cam.Death();
            if (killer != null && !killer.CompareTag("Pinxo"))
            {
                if (furro == null) pigno.killPlayer();
                else if (pigno == null) furro.killPlayer();
            }
        }
    }
    private void Respawn()
    {
        Destroy(rb);
        cuerpo.enabled = false;
        glasses.SetActive(false);
        body.anim.SetTrigger("isDead");
        head.anim.SetTrigger("isDead");
        if(killer != null && !killer.CompareTag("Pinxo"))
        {
            state.setKiller(killer);
        }
        foreach(GameObject diamond in treasureManager.getDiamonds())
        {
            diamond.SetActive(true);
            diamond.GetComponent<DiamondTreasure>().resetTimePicked();
            treasureManager.restaPunts();
        }
        state.recoverState();
    }
    public void killPlayer(GameObject enemy)
    {
        killer = enemy;
        if (enemy.CompareTag("Furro"))
        {
            FindObjectOfType<AudioManager>().Play("FurroBite");
            furro = enemy.GetComponent<Furro>();
            furro.freeze();
        }
        else if(enemy.CompareTag("Pigno"))
        {
            FindObjectOfType<AudioManager>().Play("PignoBite");
            pigno = enemy.GetComponent<Pigno>();
            pigno.freeze();
        }
    }
    public void freeKiller()
    {
        killer = null;
    }
}
