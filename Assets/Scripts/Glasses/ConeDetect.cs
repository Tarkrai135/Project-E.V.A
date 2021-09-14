using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConeDetect : MonoBehaviour
{
    [Range(0f, 360f)]
    public float visionDetect = 30f;
    public float visionDistanceDetect = 10f;
    private GameObject[] points = new GameObject[7];
    private bool detected = false;
    public Furro furro;
    public Pigno pigno;
    private bool furrito;

    private void Awake()
    {
        noneDetected();
    }
    private void FixedUpdate()
    {
        detected = false;
        if(furro != null || pigno != null)
        {
            Debug.Log("Hello?");
            isDetected(getPlayerVectors());
        }
    }
    private void OnDrawGizmos()
    {
        if (visionDetect <= 0f) return;
        float halfVisionAngle = visionDetect * 0.5f;

        Vector2 p1, p2;
        
        p1 = PointForAngle(halfVisionAngle, visionDistanceDetect);
        p2 = PointForAngle(-halfVisionAngle, visionDistanceDetect);

        Gizmos.color = detected ? Color.green : Color.red;
        Gizmos.DrawLine(transform.position, (Vector2)transform.position + p1);
        Gizmos.DrawLine(transform.position, (Vector2)transform.position + p2);

        Gizmos.DrawRay(transform.position, transform.right * visionDistanceDetect);

    }
    private Vector2 PointForAngle(float angle, float distance)
    {
        return transform.TransformDirection(new Vector2(Mathf.Cos(angle * Mathf.Deg2Rad), Mathf.Sin(angle * Mathf.Deg2Rad))) * distance;
    }
    private Vector2[] getPlayerVectors()
    {
        Vector2[] list = new Vector2[6];
        int cont = 0;
        for(int i = 1; i < points.Length; i++)
        {
            list[cont] = points[i].transform.position - transform.position;
            cont++;
        }
        return list;
    }
    private void isDetected(Vector2[] playerVectors)
    {
        for(int i = 0; i < playerVectors.Length; i++)
        {
            if (Vector3.Angle(playerVectors[i].normalized, transform.right) < visionDetect * 0.5f)
            {
                if (playerVectors[i].magnitude < visionDistanceDetect)
                {
                    detected = true;
                    if (furrito) furro.setActive(true);
                    else pigno.setActive(false);
                    return;
                }
            }
        }
        if (furrito) furro.setActive(false);
        else pigno.setActive(true);


    }
    public void setTarget(GameObject target)
    {
        Debug.Log("WTF");
        if (furrito) furro = target.GetComponent<Furro>();
        else pigno = target.GetComponent<Pigno>();

        for (var i = 0; i < 7; i++)
        {
            points[i] = target.transform.GetChild(i + 1).gameObject;
        }
    }
    public void isFurro(bool yesNo)
    {
        furrito = yesNo;
    }
    public void noneDetected()
    {
        furro = null;
        pigno = null;

    }
    public void setDistance(float n)
    {
        visionDistanceDetect = n;
    }
    public float getDistance()
    {
        return visionDistanceDetect;
    }

}
