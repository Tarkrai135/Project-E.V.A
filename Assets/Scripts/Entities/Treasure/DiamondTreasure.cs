using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondTreasure : MonoBehaviour
{
    public TreasureManager treasureManager;
    private bool first = true;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (first)
            {
                gameObject.SetActive(false);
                treasureManager.sumaPunts();
                first = false;
                treasureManager.saveDiamond(gameObject);
                FindObjectOfType<AudioManager>().Play("PowerUp");

            }

        }
    }
    public void resetTimePicked()
    {
        first = true;
    }

}
