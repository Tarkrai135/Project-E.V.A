using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saveInputsAndButtonsOnLoad : MonoBehaviour
{
    private static saveInputsAndButtonsOnLoad instance;

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
}