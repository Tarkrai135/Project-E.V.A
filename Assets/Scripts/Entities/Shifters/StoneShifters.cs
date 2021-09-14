using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneShifters : MonoBehaviour
{
    public Transform objToModify;
    public float MidaX = 0;
    public float MidaY = 0;
    public bool scaleX = false;
    public bool scaleY = false;
    public bool scaleBoth = true;
    public Vector3 initPos;
    private Vector3 size;
    public float transparencia = 0.5f;
    private Color phantasm, real;
    private Collider2D squareCollider;
    private SpriteRenderer spriteSquare;
    public bool playerIn = false, glassesIn = false;
    private GameObject child;
    
    void Start()
    {
        initPos = transform.position;
        size = objToModify.localScale;
        child = gameObject.transform.GetChild(0).gameObject;
        child.SetActive(false);
        spriteSquare = GetComponent<SpriteRenderer>();
        squareCollider = GetComponent<Collider2D>();
        phantasm = spriteSquare.color;
        real = phantasm;
        phantasm.a = transparencia;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Glasses"))
        {
            glassesIn = true;
            newSize();
            Debug.Log("glasses in");
        }
        if (collision.CompareTag("Player"))
        {
            playerIn = true;
            Debug.Log("player in");

        }
    }
    void OnTriggerExit2D(Collider2D other)
    {

        if (other.CompareTag("Glasses"))
        {
            glassesIn = false;
            Debug.Log("glasses out");

        }
        if (other.CompareTag("Player"))
        {
            playerIn = false;
            Debug.Log("player out");

        }
        if ((other.CompareTag("Player") || other.CompareTag("Glasses")) && !playerIn && !glassesIn)
        {
            originalSize();

        }
    }

    private void newSize()
    {
        child.SetActive(true);
        if (scaleBoth) objToModify.localScale = new Vector3(MidaX, MidaY, size.z);
        else if (scaleX) objToModify.localScale = new Vector3(MidaX, size.y, size.z);
        else objToModify.localScale = new Vector3(size.x, MidaY, size.z);
        spriteSquare.color = phantasm;
        squareCollider.isTrigger = true;

    }
    private void originalSize()
    {

        objToModify.localScale = size;
        spriteSquare.color = real;
        squareCollider.isTrigger = false;
        child.SetActive(false);

    }

}
