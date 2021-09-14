using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class Propulsor : MonoBehaviour
{
    public float jumpForce;
    public float maxEnergy;
    public float currentEnergy;
    public float depleteSpeed;
    public float rechargeSpeed;
    public GameObject propulsor;
    public bool engineOn;
    public bool millora = false;
    private int maxJumps;
    private bool savedImprovement = false;
    private float originalEnergy;
    private Rigidbody2D rb;
    private PlayerMovement playerMovement;
    private CollisionDetection collisionDetection;
    private Inputs input;
    private GameObject inputsAndButtons;
    public PropulsorAnimation propAnim;
    private bool engineWorking;

    private void Awake()
    {
        inputsAndButtons = GameObject.Find("InputsAndButtons");
        input = inputsAndButtons.GetComponent<Inputs>();
    }
    void Start()
    {
        engineOn = false;
        engineWorking = true;
        maxJumps = 0;
        originalEnergy = maxEnergy;

        playerMovement = GetComponent<PlayerMovement>();
        collisionDetection = GetComponent<CollisionDetection>();
        //propAnim = GetComponent<PropulsorAnimation>();


    }
    void FixedUpdate()
    {
        if (playerMovement.isKilled()) propulsor.SetActive(false);
        else propulsor.SetActive(true);

        if (!playerMovement.isKilled())
        {
            if (input.isEngineOn())
            {
                setEngineOn();
                if (engineWorking)
                {
                    if (currentEnergy > 0)
                    {
                        FindObjectOfType<AudioManager>().Play("EngineOn");
                        engineWorking = false;
                    }
                    
                }
                
            }
            else
            {
                setEngineOff();
                if (engineWorking == false)
                {
                    FindObjectOfType<AudioManager>().Stop("EngineOn");
                    engineWorking = true;
                }
                
                
            }
            rb = GetComponent<Rigidbody2D>();

            jumpPropulsor();

            checkNegativeEnergy();

            moveFlying();

            if (currentEnergy < 1)
                FindObjectOfType<AudioManager>().Stop("EngineOn");
            
        }
    }

    private void jumpPropulsor()
    {
        switch (engineOn)
        {
            case true:
                
                if (currentEnergy > 0 && maxJumps < 5)
                {
                    
                    rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
                    currentEnergy = currentEnergy - depleteSpeed * Time.deltaTime;
                    

                }
                propAnim.anim.SetBool("Propulsing", true);
                
                break;

            case false:
                
                if (currentEnergy < maxEnergy)
                {
                    
                    if (collisionDetection.IsGrounded == true)
                    {
                        currentEnergy = currentEnergy + rechargeSpeed * Time.deltaTime;
                        maxJumps = 0;
                    }
                }
                propAnim.anim.SetBool("Propulsing", false);
                break;
        }
    }

    private void moveFlying()
    {
        if (collisionDetection.IsGrounded == false)
        {
            Vector2 vel = rb.velocity;
            vel.x = playerMovement.xAxis * 3;
            rb.velocity = vel;
        }
    }

    private void checkNegativeEnergy()
    {
        if (currentEnergy < 0)
        {
            currentEnergy = 0;
        }
    }

    public void setEngineOn()
    {
         engineOn = true;

        //FindObjectOfType<AudioManager>().Play("EngineOn");
         //maxJumps++;
    }

    public void setEngineOff()
    {
        engineOn = false;
        

    }
    public void setMillora(float energy)
    {
        maxEnergy = energy;
        millora = true;
    }
    public void setOriginalEnergy()
    {
        maxEnergy = originalEnergy;
        millora = false;
    }
    public bool isImproved()
    {
        return millora;
    }
    public void saveImprovement()
    {
        savedImprovement = true;
    }
    public bool isSavedImprove()
    {
        return savedImprovement;
    }


}
