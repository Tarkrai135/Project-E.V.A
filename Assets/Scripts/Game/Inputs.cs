using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inputs : MonoBehaviour
{
    PlayerControls controls;
    private Vector2 glassesMoveGamepad;
    private Vector2 glassesMoveMouse;
    private Vector2 playerMoveKeyboard;
    private Vector2 playerMoveGamepad;
    private bool MouseKeyboard = true;
    private bool engineOn = false;
    public ButtonsManager buttonsManager;

    private void Awake()
    {

        controls = new PlayerControls();

        controls.Player.PauseGameKeyboard.performed += ctx => determinePauseKeyboardGamepad();
        controls.Player.PauseGameGamepad.performed += ctx => determinePauseKeyboardGamepad();


        controls.Player.LookGamepad.performed += ctx => glassesMoveGamepad = ctx.ReadValue<Vector2>();                                
        controls.Player.LookGamepad.canceled += ctx => glassesMoveGamepad = Vector2.zero;

        controls.Player.LookMouse.performed += ctx => glassesMoveMouse = ctx.ReadValue<Vector2>();
        controls.Player.LookMouse.canceled += ctx => glassesMoveMouse = Vector2.zero;

        controls.Player.MoveKeyboard.performed += ctx => playerMoveKeyboard = ctx.ReadValue<Vector2>();
        controls.Player.MoveKeyboard.canceled += ctx => playerMoveKeyboard = Vector2.zero;

        controls.Player.MoveGamepad.performed += ctx => playerMoveGamepad = ctx.ReadValue<Vector2>();
        controls.Player.MoveGamepad.canceled += ctx => playerMoveGamepad = Vector2.zero;

        controls.Player.EngineOnGamepad.performed += ctx => setEngineOnGamepad();
        controls.Player.EngineOffGamepad.canceled += ctx => setEngineOffGamepad();

        controls.Player.EngineOnKeyboard.performed += ctx => setEngineOnKeyboard();
        controls.Player.EngineOffKeyboard.canceled += ctx => setEngineOffKeyboard();

    }
    void OnEnable()
    {
        controls.Player.Enable();
    }
    void OnDisable()
    {
        controls.Player.Disable();
    }
    public Vector2 getMoveKeyboard()
    {
        return playerMoveKeyboard;
    }
    public Vector2 getMoveGamepad()
    {
        return playerMoveGamepad;
    }
    public Vector2 getMoveMouse()
    {
        return glassesMoveMouse;
    }
    public Vector2 getMoveJoystick()
    {
        return glassesMoveGamepad;
    }
    public bool isMouseKeyboard()
    {
        return MouseKeyboard;
    }
    public void useKeyboardAndMouse(bool choice)
    {
        MouseKeyboard = choice;
        if(MouseKeyboard)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }
    public void setEngineOnKeyboard()
    {
        if (isMouseKeyboard()) engineOn = true; ;
    }
    public void setEngineOnGamepad()
    {
        if (!isMouseKeyboard()) engineOn = true; ;
    }
    public void setEngineOffKeyboard()
    {
        if (isMouseKeyboard()) engineOn = false;
    }
    public void setEngineOffGamepad()
    {
        if (!isMouseKeyboard()) engineOn = false;
    }
    public bool isEngineOn()
    {
        return engineOn;
    }
    public void determinePauseKeyboardGamepad()
    {
        buttonsManager.determinePause();
    }

}
