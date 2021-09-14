using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextManager : MonoBehaviour
{
    public GameObject textControls;
    public GameObject textUlleres;
    public GameObject textMilloraVisio;
    public GameObject textMilloraPropulsor;
    public GameObject textPalanca;
    public GameObject textMirror;
    public GameObject textFinal;

    private void Awake()
    {
        showTextControls();
    }
    public void setGameObject(GameObject objectText)
    {
        switch (objectText.tag)
        {
            case "getGlasses": setActiveThis(textUlleres); break;
            case "MilloraVisio": setActiveThis(textMilloraVisio); break;
            case "MilloraPropulsor": setActiveThis(textMilloraPropulsor); break;
            case "Lever": setActiveThis(textPalanca); break;
            case "Mirror": setActiveThis(textMirror); break;
            default: setActiveThis(textFinal); break;
        }
    }
    private IEnumerator ExecuteAfterTime()
    {
        yield return new WaitForSeconds(7.5f);
        allDisactive();

    }
    private void setActiveThis(GameObject thisText)
    {
        allDisactive();
        thisText.SetActive(true);
        StartCoroutine("ExecuteAfterTime");
    }
    private void allDisactive()
    {
        textControls.SetActive(false);
        textUlleres.SetActive(false);
        textMilloraVisio.SetActive(false);
        textMilloraPropulsor.SetActive(false);
        textPalanca.SetActive(false);
        textMirror.SetActive(false);
        textFinal.SetActive(false);
    }
    private void showTextControls()
    {
        allDisactive();
        textControls.SetActive(true);
        StartCoroutine("ExecuteAfterTime");

    }
}
