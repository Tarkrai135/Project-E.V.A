using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State : MonoBehaviour
{

    public Mirror mirror;
    public GameObject player;
    public GameObject glasses;
    public GameObject milloraVisio;
    public GameObject milloraPropulsor;
    public Propulsor propulsor;                                     //SI TE MATAN DESPUES DE CONSEGUIR LA MEJORA DEL PROPULSOR PERO ANTES DE TOCAR UN CHECKPOINT
    public GameObject lastCheckpoint;
    public PlayerMovement playerMovement;
    public Fades fade;
    public Pigno pigno;
    public Furro furro;
    public UseLever lever;
    public GameObject openedDoor, closedDoor;
    private bool opened = false;
    private Collider2D cuerpo;
    private Vector3 CheckPointPos;
    private Vector3 initScale;
    private float mass = 0;
    private float gravity = 0;
    private bool savedCheckpoint;
    private GameObject killer;
    public Death death;
    private ConeDetect cone;
    private List<GameObject> listDiamonds = new List<GameObject>();
    private bool leverSpriteChanged = false;
    public Transparency cave;
    public Transparency bridge;
    private GameObject check;


    private void Awake()
    {
        initScale = player.transform.localScale;
        CheckPointPos = player.transform.position;
        cuerpo = player.GetComponent<BoxCollider2D>();
        mass = player.GetComponent<Rigidbody2D>().mass;
        gravity = player.GetComponent<Rigidbody2D>().gravityScale;
        cone = glasses.GetComponent<ConeDetect>();
    }

    public void recoverState()
    {
        StartCoroutine("ExecuteAfterTime");
    }
    IEnumerator ExecuteAfterTime()
    {
        yield return new WaitForSeconds(2.3f);

        fade.Respawn();

        yield return new WaitForSeconds(3.0f);

        
        player.transform.position = CheckPointPos;
        player.transform.localScale = initScale;
        mirror.sizeChangedOut();
        mirror.setOriginalLight();
        mirror.setOriginalCone();
        glasses.SetActive(true);
        cone.noneDetected();
        playerMovement.revivePlayer();
        if(killer != null)
        {
            if (!killer.CompareTag("Pinxo"))
            {
                if (killer.CompareTag("Furro"))
                {
                    furro = killer.GetComponent<Furro>();
                    furro.revivePlayer();
                    furro.unFreeze();
                }
                else
                {
                    pigno = killer.GetComponent<Pigno>();
                    pigno.revivePlayer();
                    pigno.unFreeze();
                }
            }
            death.freeKiller();
            killer = null;
        }

        player.AddComponent<Rigidbody2D>();                  
        player.GetComponent<Rigidbody2D>().mass = mass;
        player.GetComponent<Rigidbody2D>().gravityScale = gravity;
        cuerpo.enabled = true;

        if (!glasses.GetComponent<GlassesMov>().isSavedImprove())
        {
            glasses.GetComponent<GlassesMov>().loseImprovement();
            milloraVisio.SetActive(true);
        }
        if (!propulsor.isSavedImprove())
        {
            propulsor.setOriginalEnergy();
            milloraPropulsor.SetActive(true);
        }
        if (savedCheckpoint) lastCheckpoint.SetActive(true);
        else lastCheckpoint.SetActive(false);

        if (opened)
        {
            openedDoor.SetActive(true);
            closedDoor.SetActive(false);            
        }
        else
        {
            openedDoor.SetActive(false);
            closedDoor.SetActive(true);
        }
        if (leverSpriteChanged)
        {
            lever.originalSprite(false);
        }
        else
        {
            lever.originalSprite(true);
        }
        yield return new WaitForSeconds(2.8f);
        cave.sprite.sortingLayerName = "Player";
        bridge.sprite.sortingLayerName = "Player";
        
        yield return new WaitForSeconds(5f);
        

    }
    public void setCheckPoint(Vector3 pos, GameObject checkpoint)
    {
        CheckPointPos = pos;
        if(check != null && check.name != checkpoint.name)
        {
            check.GetComponent<CheckPoint>().forgetCheckpoint();
            Debug.Log(check);
        }
        check = checkpoint;

    }
    public void saveLastCheckPoint()
    {
        savedCheckpoint = true;
    }
    public void setDoors(bool open)
    {
        opened = open;
    }
    public void setKiller(GameObject enemy)
    {
        killer = enemy;
    }
    public void saveDiamonds(List<GameObject> list)
    {
        foreach(GameObject diamond in list)
        {
            listDiamonds.Add(diamond);
        }
        listDiamonds = list;
    }
    public void usedLever(bool yes)
    {
        leverSpriteChanged = yes;
    }
}
