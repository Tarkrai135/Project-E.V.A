using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Energy : MonoBehaviour
{

    public Propulsor propulsor;
    public Slider slider;

    void Start()
    {
       slider.maxValue = propulsor.maxEnergy;
    }


    void FixedUpdate()
    {
        slider.value = propulsor.currentEnergy;       
    }
}
