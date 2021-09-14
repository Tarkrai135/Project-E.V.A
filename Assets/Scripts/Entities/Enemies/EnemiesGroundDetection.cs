using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesGroundDetection : MonoBehaviour
{
    public Furro furro;
    public Pigno pigno;
    [SerializeField]
    private bool _isGrounded;
    [SerializeField]
    private LayerMask WhatIsGround;
    public float checkRadius = 0.05f;
    public bool IsGrounded { get { return _isGrounded; } }
    void FixedUpdate()
    {
        CheckGrounded();
        if (furro != null)
        {
            if (!_isGrounded) furro.willFall();
            else furro.willNotFall();
        }

        if (pigno != null)
        {
            if (!_isGrounded) pigno.willFall();
            else pigno.willNotFall();
        }

    }
    private void CheckGrounded()
    {
        var colliders = Physics2D.OverlapCircleAll(transform.position, checkRadius, WhatIsGround);
        _isGrounded = colliders.Length > 0;
    }
}
