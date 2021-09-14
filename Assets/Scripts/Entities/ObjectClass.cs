using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectClass : MonoBehaviour
{
    private Vector3 initPos;

    public void Start()
    {
        
        GameEvents.current.onCheckpointEnter += ReturnInitPos;
        initPos = SaveInitTransform();
        
    }

    public Vector3 SaveInitTransform()
    {
        return gameObject.transform.position;
    }
    public void ReturnInitPos()
    {
        StartCoroutine("ExecuteDeathAfterTime");
        
    }

    IEnumerator ExecuteDeathAfterTime()
    {
        yield return new WaitForSeconds(5.3f);
        this.transform.position = initPos;
    }


}
