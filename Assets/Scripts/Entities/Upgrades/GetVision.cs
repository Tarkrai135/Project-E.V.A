using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetVision : UpgradesClass
{
    public UnityEngine.Experimental.Rendering.Universal.Light2D lightCone;
    public TextManager textManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            glasses.GetComponent<Collider2D>().enabled = true;
            lightCone.enabled = true;
            UpgradeAchieved();
            textManager.setGameObject(gameObject);
        }
    }
}
