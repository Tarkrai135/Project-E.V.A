using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saveMenuOnLoad : MonoBehaviour
{
    private static saveMenuOnLoad instance;

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
