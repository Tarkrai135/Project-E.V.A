using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovablePlatforms : ObjectClass
{
    public float velocity = 2;
    public float distance = 2;
    public bool horizontal = true;
    private GameObject[] player;
    private bool active = false;
    private Vector2 initialPos, finalPos;
    private Vector3 mov = Vector3.zero;
    private Vector2 originalFinalPos, originalIniPos;

    new void Start()
    {
        initialPos = transform.position;

        if (horizontal) finalPos = new Vector2(transform.position.x + distance, transform.position.y);
        else finalPos = new Vector2(transform.position.x, transform.position.y + distance);
        originalIniPos = initialPos;
        originalFinalPos = finalPos;
        base.Start();
        player = GameObject.FindGameObjectsWithTag("Player");

    }

    void FixedUpdate()
    {
        if (transform.CompareTag("PlatformSpecial")) active = true;
        if (active)
        {          
            if (horizontal)
            {
                if (distance > 0)
                {
                    if (fromIniToFinal()) mov = new Vector3(velocity, 0, 0);
                    else if (fromFinalToIni()) mov = new Vector3(-velocity, 0, 0);
                }
                else
                {
                    if (fromIniToFinalInverse()) mov = new Vector3(-velocity, 0, 0);
                    else if (fromFinalToIniInverse()) mov = new Vector3(velocity, 0, 0);
                }
            }
            else
            {
                if(distance > 0)
                {
                    if (fromIniToFinal()) mov = new Vector3(0, velocity, 0);
                    else if (fromFinalToIni()) mov = new Vector3(0, -velocity, 0);
                }
                else
                {
                    if (fromIniToFinalInverse()) mov = new Vector3(0, -velocity, 0);
                    else if (fromFinalToIniInverse()) mov = new Vector3(0, velocity, 0);
                }
            }

            transform.position += (mov * Time.deltaTime);

        }
    }

    private bool fromFinalToIniInverse()
    {
        if(horizontal) return transform.position.x <= finalPos.x;
        return transform.position.y <= finalPos.y;
    }

    private bool fromIniToFinalInverse()
    {
        if (horizontal) return transform.position.x >= initialPos.x;
        return transform.position.y >= initialPos.y;
    }

    private bool fromFinalToIni()
    {
        if (horizontal) return transform.position.x >= finalPos.x;
        return transform.position.y >= finalPos.y;
    }

    private bool fromIniToFinal()
    {
        if (horizontal) return transform.position.x <= initialPos.x;
        return transform.position.y <= initialPos.y;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Glasses") && !transform.CompareTag("PlatformSpecial")) active = true;

    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Glasses") && !transform.CompareTag("PlatformSpecial")) active = false;
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player") && (transform.CompareTag("Platform") || transform.CompareTag("PlatformSpecial")))
        {
            player[0].transform.SetParent(transform);
        }
        if (collision.transform.CompareTag("Platform") || collision.transform.CompareTag("BlockingRock"))
        {
            if(distance>0) finalPos = transform.position;
            else initialPos = transform.position;
        }

    }
    public void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player") && (transform.CompareTag("Platform") || transform.CompareTag("PlatformSpecial")))
        {
            player[0].transform.SetParent(null);
        }
        if (collision.transform.CompareTag("Platform") || collision.transform.CompareTag("BlockingRock"))
        {
            if (distance > 0) finalPos = originalFinalPos;
            else initialPos = originalIniPos;
        }
    }
}
