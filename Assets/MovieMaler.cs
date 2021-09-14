using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class MovieMaler : MonoBehaviour
{
    public VideoPlayer intro1, intro2, intro3;
    public ButtonsManager game;
    private static MovieMaler instance;

    private void Awake()
    {
        DontDestroyOnLoad(this);

        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

    }
    private void Start()
    {
        pauseFirstVideo();
    }

    // Update is called once per frame
    void Update()
    {
       
        
    }

    public void pauseFirstVideo()
    {
        intro1.Pause();
    }

    public void setMovie(GameObject intro)
    {
        switch (intro.name)
        {
            case "Intro_1":
                intro1 = intro.GetComponent<VideoPlayer>();
                pauseFirstVideo();
                break;
            case "Intro_2":
                intro2 = intro.GetComponent<VideoPlayer>();
                break;
            case "Intro_3":
                intro3 = intro.GetComponent<VideoPlayer>();
                break;
        }
       
    }


    public void PlayIntro()
    {
        intro1.Play();
        
        StartCoroutine("ExecuteAfterTime");
    }

    IEnumerator ExecuteAfterTime()
    {
        yield return new WaitForSeconds(16.0f);
        intro2.Play();
        yield return new WaitForSeconds(10.0f);
        intro3.Play();
        yield return new WaitForSeconds(4.0f);
        SceneManager.LoadScene("Main");

    }
}
