using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseLever : MonoBehaviour
{
    public GameObject checkpoint;
    public TextManager textManager;

    public SpriteRenderer spriteRenderer;
    public GameObject closedDoor;
    public GameObject openedDoor;
    public Sprite sprite;
    private Sprite original;
    private bool changed = false;

    private void Awake()
    {
        original = spriteRenderer.sprite;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            textManager.setGameObject(gameObject);
            closedDoor.SetActive(false);
            openedDoor.SetActive(true);
            checkpoint.SetActive(true);
            spriteRenderer.sprite = sprite;
            changed = true;
            
        }
    }
    public void originalSprite(bool yes)
    {
        if (yes)
        {
            spriteRenderer.sprite = original;
            changed = false;
        }
        else
        {
            spriteRenderer.sprite = sprite;
        }
    }
    public bool isUsed()
    {
        return changed;
    }
}
