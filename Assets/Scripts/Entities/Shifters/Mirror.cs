using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mirror : MonoBehaviour
{
    public GameObject player;
    public ConeDetect cone;
    private float originalCone;
    private bool sizeChanged = false;
    public float reduceXtimes = 1;
    private float originalLight;
    public UnityEngine.Experimental.Rendering.Universal.Light2D lightCone;
    private Vector3 originalSize;
    public PlayerMovement play;
    public float secondsUse = 3f;
    public TextManager textManager;
    public bool firstTimeText = true;

    void Start()
    {
        originalSize = player.transform.localScale;
        originalLight = lightCone.pointLightOuterRadius;
        originalCone = cone.getDistance();
    }
    private void FixedUpdate()
    {
        if (play.isKilled()) sizeChanged = false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Glasses"))
        {
            if (firstTimeText)
            {
                textManager.setGameObject(gameObject);
                firstTimeText = false;
            } 
            if (!sizeChanged)
            {
                player.transform.position = new Vector2(player.transform.position.x, player.transform.position.y + .5f);
                player.transform.localScale = player.transform.localScale / reduceXtimes;
                lightCone.pointLightOuterRadius = originalLight / reduceXtimes;
                cone.setDistance(originalCone / reduceXtimes);
                sizeChanged = true;
            }
            else
            {
                cone.setDistance(originalCone);
                player.transform.localScale = originalSize;
                lightCone.pointLightOuterRadius = originalLight;
                sizeChanged = false;
            }
            waitUseMirror();
        }
    }
    public void sizeChangedOut()
    {
        sizeChanged = false;
    }
    public void setOriginalLight()
    {
        lightCone.pointLightOuterRadius = originalLight;
    }
    public void waitUseMirror()
    {
        StartCoroutine("ExecuteAfterTime");
    }
    IEnumerator ExecuteAfterTime()
    {
        gameObject.GetComponent<Collider2D>().enabled = false;
        yield return new WaitForSeconds(secondsUse);
        gameObject.GetComponent<Collider2D>().enabled = true;

    }
    public void setOriginalCone()
    {
        cone.setDistance(originalCone);
    }
}
