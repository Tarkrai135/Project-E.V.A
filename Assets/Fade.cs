using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class Fade : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject canvas;
    public ButtonsManager game;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (game.gameStarted)
        {
            //canvas.SetActive(false);
        }




    }

    IEnumerator ExecuteAfterTime()
    {
        yield return new WaitForSeconds(.4f);
        
    }
}
