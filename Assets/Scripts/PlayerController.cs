using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerController : MonoBehaviour
{
    public Rigidbody ourQuis; // the Quis has a rigid body attached
    public Transform ourPos; // the position where the Quis will appear!
    Rigidbody quisInstance;

    

    public Text Youwon;
    public bool YouwonDisplayed;

    public Text Youlost;
    public bool YoulostDisplayed;

    public Image lostBackground;
    public bool lostBackgroundDisplayed;

    public Text Startyay;
    public bool StartDisplayed;

    public Image StartBackground;
    public bool StartBackgroundDisplayed;





    public float cooldownTime = 10.0f;
    private float nextFireTime = 0.0f;


    // Start is called before the first frame update

    private void Start()
    {
        Youwon.gameObject.SetActive(false);
        YouwonDisplayed = false;
        Youlost.gameObject.SetActive(false);
        YoulostDisplayed = false;
        lostBackground.gameObject.SetActive(false);
        lostBackgroundDisplayed = false;
        Startyay.gameObject.SetActive(true);
        StartDisplayed = true;
        StartBackground.gameObject.SetActive(true);
        StartBackgroundDisplayed = true;

    }

     


// Update is called once per frame
void Update()
    { if (Input.GetKey(KeyCode.UpArrow))
        { transform.Translate(0, 0, 12 * Time.deltaTime);
            transform.rotation = Quaternion.Euler(0, 0, 0);
            Startyay.gameObject.SetActive(false);
            StartDisplayed = false;
            StartBackground.gameObject.SetActive(false);
            StartBackgroundDisplayed = false;
        }


        else if (Input.GetKey(KeyCode.DownArrow))
        { transform.Translate(0, 0, 12 * Time.deltaTime);
            transform.rotation = Quaternion.Euler(0, 180, 0);
            Startyay.gameObject.SetActive(false);
            StartDisplayed = false;
            StartBackground.gameObject.SetActive(false);
            StartBackgroundDisplayed = false;
        }

        else if (Input.GetKey(KeyCode.LeftArrow))
        { transform.Translate(0, 0, 12 * Time.deltaTime);
            transform.rotation = Quaternion.Euler(0, 270, 0);
            Startyay.gameObject.SetActive(false);
            StartDisplayed = false;
            StartBackground.gameObject.SetActive(false);
            StartBackgroundDisplayed = false;
        }

        else if (Input.GetKey(KeyCode.RightArrow))
        { transform.Translate(0, 0, 12 * Time.deltaTime);
            transform.rotation=Quaternion.Euler(0, 90, 0);
            Startyay.gameObject.SetActive(false);
            StartDisplayed = false;
            StartBackground.gameObject.SetActive(false);
            StartBackgroundDisplayed = false;
        }



        if (YouwonDisplayed)
        { youwonhehe(); }

        if (YoulostDisplayed)
        { youlostohno(); }
        if (lostBackgroundDisplayed) 
        { youlostohno(); }
        if (StartDisplayed)
        { youcanstart(); }
        if (StartBackgroundDisplayed)
        { youcanstart(); }

        if (Time.time > nextFireTime)
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                summonQuis();
                print("summonQuis, cooldown started");
                nextFireTime = Time.time + cooldownTime;
            }
        }

    }
    void summonQuis()
    {
        ourPos = transform;
        if (quisInstance == null)
            quisInstance = Instantiate(ourQuis, ourPos.position, ourPos.rotation) as Rigidbody;// make Quis appear

    }

   
    void OnTriggerEnter(Collider collision)
        {
        if (collision.gameObject.name.Equals("winningSpace"))
        {
            Youwon.gameObject.SetActive(true);
            YouwonDisplayed = true;
            StartBackground.gameObject.SetActive(false);
            StartBackgroundDisplayed = false;
        }
        
        if (collision.gameObject.name.Equals("Guard Sphere") || collision.gameObject.name.Equals("Police"))
        { 
            if(Vector3.Distance(transform.position, collision.transform.position) < 3)
            {
                Youlost.gameObject.SetActive(true);
                YoulostDisplayed = true;
                lostBackground.gameObject.SetActive(true);
                lostBackgroundDisplayed = true;
                Startyay.gameObject.SetActive(false);
                StartDisplayed = false;
                StartBackground.gameObject.SetActive(false);
                StartBackgroundDisplayed = false;
            }
           

        }
        else
        {
            Youlost.gameObject.SetActive(false);
            YoulostDisplayed = false;
            lostBackground.gameObject.SetActive(false);
            lostBackgroundDisplayed = false;
            Startyay.gameObject.SetActive(false);
            StartDisplayed = false;
            StartBackground.gameObject.SetActive(false);
            StartBackgroundDisplayed = false;

        }

    }

   

    void youwonhehe()
        {
            Debug.Log("I got the meat and won this level");
        Time.timeScale = 0;
            //YouwonDisplayed = false;
            //Youwon.gameObject.SetActive(false);

        }
    void youlostohno()
    {
        Debug.Log("ohhhhhh damn.. I died");
        Time.timeScale = 0;
    }
    void youcanstart()
    {
        Debug.Log("yay! hope you like the game");
        
    }





}
