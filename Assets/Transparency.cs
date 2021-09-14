using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transparency : MonoBehaviour
{
    // Start is called before the first frame update

    private bool isInvisible;
    public PlayerMovement player;

    public SpriteRenderer sprite;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (player.isKilled())
        {
            sprite.sortingLayerName = "Objects";
        }

        
        
    }

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
           
            sprite.color = new Color(1f, 1f, 1f, 0.7f);
            
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            sprite.color = new Color(1f, 1f, 1f, 1f);

        }
    }
}
