using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;

public class GameEvents : MonoBehaviour
{
    public static GameEvents current;
    private void Awake()
    {
        current = this;
    }

    public event Action onCheckpointEnter;
    public void CheckPointStarted()
    {
        if (onCheckpointEnter != null)
        {
            onCheckpointEnter();
        }
    }

    
}
