using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
   
    public Transform player;
    public float cameraOffset = 15;
    public PlayerMovement playerMovement;
    public Propulsor prop;

    private Camera cam;
    private Vector3 cameraPosition;
    private Vector3 initPos;
    private float verticalOffset;

    private float horizonatlOffset;
    private bool followPlayer;
    private bool death;
    private bool upgraded;


    private void Start()
    {
        cam = GetComponent<Camera>();

        initPos = transform.position;

        verticalOffset = 1.2f;
        horizonatlOffset = 0;
        followPlayer = true;
        death = false;
        upgraded = false;

        
        
    }

    private void FixedUpdate()
    {
        if (followPlayer)
        {
            SoftCameraMovement();
        }

        if (upgraded)
        {
            ZoomCamera(2f, 1, 0.1f, 1f);
        }

        if (death)
        {
            //ZoomCamera(2f,-3,0.1f,0.1f);
            PlayerDied();
        }
    }

    void SoftCameraMovement()
    {

        if (cam.orthographicSize < 5)
        {
            cam.orthographicSize += 0.5f;
        }
        
        if (playerMovement.xAxis < 0)
        {
            if(horizonatlOffset >-2) horizonatlOffset -= Time.deltaTime;
        }
        if (playerMovement.xAxis > 0)
        {
            if (horizonatlOffset < 2) horizonatlOffset += Time.deltaTime;
        }

        cameraPosition = Vector3.MoveTowards(transform.position, new Vector3(player.position.x+horizonatlOffset, player.position.y + verticalOffset, player.position.z), Time.time / cameraOffset);
        cameraPosition = new Vector3(cameraPosition.x, cameraPosition.y, -10);
        
        transform.position = cameraPosition;

    }

    void ZoomCamera(float size, float yPos, float zoomSpeed, float posSpeed)
    {
        if (cam.orthographicSize > size)
        {
            cam.orthographicSize -= zoomSpeed;
            cam.transform.position = Vector3.Lerp(cam.transform.position, new Vector3(cam.transform.position.x, cam.transform.position.y + yPos, cam.transform.position.z), Time.deltaTime * posSpeed);
        }

        StartCoroutine("ExecuteAfterTime");
        
    }

    void PlayerDied()
    {

        if (cam.orthographicSize > 2)
        {
            cam.orthographicSize -= 0.1f;
            cameraPosition = Vector3.Lerp(cam.transform.position, new Vector3(player.position.x, player.position.y, cam.transform.position.z), Time.time / cameraOffset);

            if (prop.engineOn)
            {
                player.position = Vector3.Lerp(player.position, new Vector3(player.position.x, player.position.y, player.position.z), Time.time / cameraOffset);
                //cam.transform.position = cameraPosition;
            }

            cam.transform.position = cameraPosition;
            
        }
        
        StartCoroutine("ExecuteAfterTimeDead");

    }

    public void GetUpgrade()
    {
        followPlayer = false;
        upgraded = true;

    }

    public void Death()
    {
        followPlayer = false;
        death = true;
    }



    private IEnumerator ExecuteAfterTime()
    {
        yield return new WaitForSeconds(3.5f);
        upgraded = false;
        death = false;
        followPlayer = true;

    }

    private IEnumerator ExecuteAfterTimeDead()
    {
        yield return new WaitForSeconds(5.5f);
        upgraded = false;
        death = false;
        followPlayer = true;
        
    }
}
