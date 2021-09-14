using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImprovePropulsor : UpgradesClass
{
    public float maxEnergy = 100;
    public TextManager textManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Propulsor>().setMillora(maxEnergy);
            UpgradeAchieved();
            textManager.setGameObject(gameObject);
        }
    }
}
