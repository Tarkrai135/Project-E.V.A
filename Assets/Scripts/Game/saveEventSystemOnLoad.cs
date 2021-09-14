using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saveEventSystemOnLoad : MonoBehaviour
{
    private static saveEventSystemOnLoad instance;

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