using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImproveVision : UpgradesClass
{
    //public GlassesMov glasses;
    public TextManager textManager;
    public GameObject desactivar;
    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            glasses.setMillora();
            desactivar.SetActive(false);
            UpgradeAchieved();
            textManager.setGameObject(gameObject);
            //gameObject.SetActive(false);
        }
    }
}
