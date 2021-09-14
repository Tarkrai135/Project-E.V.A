using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TreasureManager : MonoBehaviour
{
    public TextMeshProUGUI txt;
    private int puntuacio;
    private List<GameObject> diamonds = new List<GameObject>();
    void Start()
    {
        puntuacio = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void sumaPunts()
    {
        puntuacio++;
        txt.text = puntuacio.ToString() + "/6";
    }
    public void restaPunts()
    {
        puntuacio--;
        txt.text = puntuacio.ToString() + "/6";
    }
    public int getPuntuacio()
    {
        return puntuacio;
    }
    public void saveDiamond(GameObject diamond)
    {
        diamonds.Add(diamond);
    }
    public List<GameObject> getDiamonds()
    {
        List<GameObject> newDiamonds;
        newDiamonds = diamonds;
        diamonds = new List<GameObject>();
        return newDiamonds;
    }
}
