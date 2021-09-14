using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class DiamondFinal : UpgradesClass
{
    private GameObject[] inputAndButtons;
    private ButtonsManager buttonsManager;
    public TextManager textFinal;
    public SpriteRenderer sprite;
    public VideoPlayer VideoFinal;
    private void Awake()
    {
        inputAndButtons = GameObject.FindGameObjectsWithTag("InputAndButtons");
        buttonsManager = inputAndButtons[0].GetComponent<ButtonsManager>();


    }
    void FixedUpdate()
    {
        Debug.Log(VideoFinal.isPlaying);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
            textFinal.setGameObject(gameObject);
            sprite.sortingLayerName = "Player";
            //UpgradeAchieved();
            StartCoroutine("ExecuteAfterTime");
        }
    }
    private IEnumerator ExecuteAfterTime()
    {
        VideoFinal.Play();
        Debug.Log(VideoFinal.isPlaying);
        yield return new WaitForSeconds(8f);
        Destroy(gameObject);
        buttonsManager.win();
    }
}
