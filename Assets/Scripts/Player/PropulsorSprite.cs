using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropulsorSprite : MonoBehaviour
{
    public PlayerMovement playerMov;
    

    private Propulsor propulsor;
    private Vector3 initPosition;
    private Vector3 initPos;



    // Start is called before the first frame update
    private void Start()
    {
        propulsor = gameObject.GetComponentInParent<Propulsor>();

        initPos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        
    }

    // Update is called once per frame
    void Update()
    {

        if (playerMov.xAxis > 0)
        {
            //transform.eulerAngles = new Vector3(transform.position.x, transform.position.y, -30.0f);
            transform.position = new Vector3(playerMov.transform.position.x - 0.2f, transform.position.y, transform.position.z);
        }
        else
        {
            //transform.eulerAngles = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            transform.position = new Vector3(playerMov.transform.position.x, transform.position.y, transform.position.z);
        }
        if (playerMov.xAxis < 0)
        {
            //transform.eulerAngles = new Vector3(transform.position.x, transform.position.y, 30.0f);
            transform.position = new Vector3(playerMov.transform.position.x + 0.2f, transform.position.y, transform.position.z);
        }



    }
}
