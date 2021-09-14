using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    [SerializeField]
    private bool _isGrounded;
    public bool IsGrounded { get { return _isGrounded; } }

    [SerializeField]
    private bool _isTouchingFront;
    public bool IsTouchingFront { get { return _isTouchingFront; } }

    [SerializeField]
    private bool _isTouchingEnemy;
    public bool isTouchingEnemy { get { return _isTouchingEnemy; } }

    public PlayerMovement playerMovement;
    [SerializeField]
    public Transform groundCheck;
    [SerializeField]
    private Transform FrontCheckPoint;
    [SerializeField]
    private LayerMask WhatIsGround;
    public float checkRadius = 0.05f;
    private bool checkfrontFliped = false;
    public Death death;
    private GameObject killer;

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(groundCheck.position, checkRadius);
        Gizmos.color = Color.white;
        Gizmos.DrawWireCube(FrontCheckPoint.position, FrontCheckPoint.localScale);

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Furro") {
            Debug.Log("Furro");
            _isTouchingEnemy = true;
            playerMovement.killPlayer();
            killer = collision.gameObject;
            death.killPlayer(killer);

        }
        if (collision.collider.tag == "Pigno")
        {
            Debug.Log("Pigno");
            _isTouchingEnemy = true;
            playerMovement.killPlayer();
            killer = collision.gameObject;
            death.killPlayer(killer);
        }
        if(collision.collider.tag == "Pinxo")
        {
            Debug.Log("Pinxo");
            _isTouchingEnemy = true;
            killer = collision.gameObject;
            playerMovement.killPlayer();
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "Furro" || collision.collider.tag == "Pigno" || collision.collider.tag == "Pinxo")
        {
            Debug.Log("Adeuuu enemic");
            _isTouchingEnemy = false;
        }

    }
    private void FixedUpdate()
    {
        CheckGrounded();
        CheckFront();
    }
    private void CheckGrounded()
    {
        var colliders = Physics2D.OverlapCircleAll(groundCheck.position, checkRadius, WhatIsGround);
        _isGrounded = colliders.Length > 0;
    }
    private void CheckFront()
    {
        var colliders = Physics2D.OverlapBoxAll(FrontCheckPoint.position, FrontCheckPoint.localScale, WhatIsGround);
        for (int i = 0; i < colliders.Length; i++)
        {
            if (colliders[i].tag == "Wall")
            {
                _isTouchingFront = true;
                return;
            }
            else _isTouchingFront = false;
        }

    }
    public void flipFront(Vector2 flip)
    {
        checkfrontFliped = !checkfrontFliped;
        FrontCheckPoint.localPosition = new Vector2(-FrontCheckPoint.localPosition.x, FrontCheckPoint.localPosition.y);
    }
    public bool getCheckfrontFliped()
    {
        return checkfrontFliped;
    }
    public bool getIsTouchingFront()
    {
        return _isTouchingFront;
    }
    public GameObject getKiller()
    {
        return killer;
    }
}
