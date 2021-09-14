using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{

    public Propulsor propulsor;
    public GlassesMov glasses;
    public State state;
    public GameObject finalCheckpoint;
    public GameObject openedDoor;
    public TreasureManager treasureManager;
    public Sprite newSprite;
    private Sprite spriteOriginal;
    public GameObject lightToActive;
    public GameObject lever;

    private void Awake()
    {
        spriteOriginal = gameObject.GetComponent<SpriteRenderer>().sprite;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = newSprite;
            lightToActive.SetActive(true);
            state.saveDiamonds(treasureManager.getDiamonds());
            state.setDoors(openedDoor.activeSelf);
            if (finalCheckpoint.activeSelf) state.saveLastCheckPoint();
            state.setCheckPoint(transform.position, gameObject);
            if (propulsor.isImproved()) propulsor.saveImprovement();
            if (glasses.isImproved()) glasses.saveImprovement();
            state.usedLever(lever.GetComponent<UseLever>().isUsed());

            Debug.Log("Saving...");
        }
    }
    public void forgetCheckpoint()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = spriteOriginal;
        lightToActive.SetActive(false);

    }




}
