using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class buttonSelect : MonoBehaviour, ISelectHandler, IPointerEnterHandler, IDeselectHandler
{
    public Button primaryButton;
    private Image fletxa;
    public AudioSource source;

    private void Awake()
    {
        fletxa = gameObject.transform.Find("Fletxa").GetComponent<Image>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        primaryButton.Select();
    }
    public void OnSelect(BaseEventData eventData)
    {
        fletxa.enabled = true;
        source.Play();
    }
    public void OnDeselect(BaseEventData eventData)
    {
        fletxa.enabled = false;
    }
}
