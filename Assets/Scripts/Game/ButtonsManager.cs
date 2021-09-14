using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class ButtonsManager : MonoBehaviour
{

    public static bool paused = false;
    public GameObject mainMenu, controlsMenu, pauseMenu, winMenu, panel;
    public Inputs input;
    public Button firstMain, firstControls, firstPause, firstWin;
    public GameObject eventSystem;
    public GameObject canvas;
    private PlayerInput c;
    private bool firstTime = true;
    private Image backgroundStart;
    public GameObject text;
    public AudioSource source;
    public bool gameStarted = false;
    public MovieMaler movies;

    private void Awake()
    {
        c = eventSystem.GetComponent<PlayerInput>();                                    //CHAPUZA CONTROLADOR MENUS   
        backgroundStart = canvas.GetComponent<Image>();

    }
    public void determinePause()
    {
        if (SceneManager.GetActiveScene().name == "Main")
        {
            if (paused)
            {
                resumeGame();
            }
            else
            {
                pauseGame();
            }
        }


    }
    public void resumeGame()
    {
        text.SetActive(false);
        EventSystem.current.SetSelectedGameObject(null);
        Time.timeScale = 1;
        paused = false;
        pauseMenu.SetActive(false);
        controlsMenu.SetActive(false);
        panel.SetActive(false);
        //Gamepad.current.SetMotorSpeeds(0, 0);

    }
    public void pauseGame()
    {
        text.SetActive(true);
        EventSystem.current.SetSelectedGameObject(null);
        Time.timeScale = 0;
        paused = true;
        pauseMenu.SetActive(true);
        panel.SetActive(true);
        //Gamepad.current.SetMotorSpeeds(0.25f, 0.75f);
        firstPause.Select();

        if (firstTime)
        {
            c.enabled = true;
            c.enabled = false;                                                     //CHAPUZA CONTROLADOR MENUS             
            firstTime = false;
        }
    }
    public void startGame()
    {
        gameStarted = true;
        backgroundStart.enabled = false;
        text.SetActive(false);
        EventSystem.current.SetSelectedGameObject(null);
        movies.PlayIntro();                                                           //AQUI DESACTIVEM VIDEO PER ANAR RAPIIIIIIIIIIIIIIIIIID
        //SceneManager.LoadScene("Main");
        if(firstTime) c.enabled = false;                                            //CHAPUZA CONTROLADOR MENUS   
        mainMenu.SetActive(false);
        pauseMenu.SetActive(false);
        controlsMenu.SetActive(false);

    }
    public void backStart()
    {
        backgroundStart.enabled = true;
        text.SetActive(true);
        SceneManager.LoadScene("Start");
        if (Time.timeScale == 0)
        {                         
            Time.timeScale = 1;
            paused = false;
        }
        EventSystem.current.SetSelectedGameObject(null);
        pauseMenu.SetActive(false);
        panel.SetActive(false);
        mainMenu.SetActive(true);
        firstMain.Select();
    }
    public void exit()
    {
        Application.Quit();
    }
    public void back()
    {
        source.Play();
        EventSystem.current.SetSelectedGameObject(null);
        if (SceneManager.GetActiveScene().name == "Main")
        {
            pauseMenu.SetActive(true);
            firstPause.Select();
        }
        else
        {
            mainMenu.SetActive(true);
            firstMain.Select();
        }

        controlsMenu.SetActive(false);
        winMenu.SetActive(false);
    }
    public void setControls()
    {
        source.Play();
        EventSystem.current.SetSelectedGameObject(null);
        mainMenu.SetActive(false);
        pauseMenu.SetActive(false);
        controlsMenu.SetActive(true);
        firstControls.Select();
    }
    public void setMouseKeyboard()
    {
        source.Play();
        input.useKeyboardAndMouse(true);
        Debug.Log(input.isMouseKeyboard());
    }
    public void setGamepad()
    {
        source.Play();
        input.useKeyboardAndMouse(false);
        Debug.Log(input.isMouseKeyboard());
    }
    public void win()
    {
        backgroundStart.enabled = true;
        SceneManager.LoadScene("Start");
        if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
            paused = false;
        }
        EventSystem.current.SetSelectedGameObject(null);
        pauseMenu.SetActive(false);
        text.SetActive(true);
        panel.SetActive(false);
        winMenu.SetActive(true);
        firstWin.Select();
    }
}
