using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseManager : MonoBehaviour
{
    public Texture2D mouse;
    private void Awake()
    {
        Cursor.SetCursor(mouse, Vector2.zero, CursorMode.Auto); 
    }
}
