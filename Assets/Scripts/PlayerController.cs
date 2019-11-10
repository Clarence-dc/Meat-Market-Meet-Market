using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerController : MonoBehaviour
{
    public Rigidbody ourQuis; // the Quis has a rigid body attached
    public Transform ourPos; // the position where the Quis will appear!
    Rigidbody quisInstance;
    public bool HasMeat;

    private Text Youwon;
    private bool YonwonDisplayed;

    
    

    // Start is called before the first frame update
    void Start()
    {
		
    }

    // Update is called once per frame
    void Update()
    { if (Input.GetKey(KeyCode.UpArrow))
        {transform.Translate(0, 0, 12 * Time.deltaTime);}
   

       else if(Input.GetKey(KeyCode.DownArrow))
        { transform.Translate(0, 0, -12 * Time.deltaTime); }

        else if(Input.GetKey(KeyCode.LeftArrow))
        { transform.Translate(-12 * Time.deltaTime, 0,0 ); }

        else if(Input.GetKey(KeyCode.RightArrow))
        { transform.Translate(12 * Time.deltaTime, 0, 0); }

        Debug.Log(transform.position);

        if(Input.GetKeyDown(KeyCode.Q))
        { summonQuis(); }

        
    }
    void summonQuis()
    {
        ourPos = transform;
        if (quisInstance == null)
            quisInstance = Instantiate(ourQuis, ourPos.position, ourPos.rotation) as Rigidbody;// make Quis appear
 
    }
}
