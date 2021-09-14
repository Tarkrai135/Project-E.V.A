using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradesClass : MonoBehaviour
{
    public CameraManager cam;
    public GlassesMov glasses;
    public PlayerMovement player;
    public Vector2 originalPos;
    // Update is called once per frame

    private void Awake()
    {
        originalPos = transform.position;
    }

    public void UpgradeAchieved()
    {
        
        cam.GetUpgrade();
        transform.position = new Vector3(cam.transform.position.x, cam.transform.position.y + 1, transform.position.z);
        player.freeze = true;

        StartCoroutine("ExecuteAfterTime");
    }


    IEnumerator ExecuteAfterTime()
    {
        yield return new WaitForSeconds(0.4f);
        FindObjectOfType<AudioManager>().Play("PowerUp");
        yield return new WaitForSeconds(2.6f);
        transform.position = originalPos;
        gameObject.SetActive(false);

        player.freeze = false;
        
        
    }
}
