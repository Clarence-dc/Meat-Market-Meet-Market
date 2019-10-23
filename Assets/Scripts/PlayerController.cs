using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody ourQuis; // the Quis has a rigid body attached
    public Transform ourPos; // the position where the Quis will appear!
    Rigidbody quisInstance; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { if (Input.GetKey(KeyCode.UpArrow))
        {transform.Translate(0, 0, 5 * Time.deltaTime);}

        if(Input.GetKey(KeyCode.DownArrow))
        { transform.Translate(0, 0, -5 * Time.deltaTime); }

        if(Input.GetKey(KeyCode.LeftArrow))
        { transform.Translate(-5 * Time.deltaTime, 0,0 ); }

        if(Input.GetKey(KeyCode.RightArrow))
        { transform.Translate(5 * Time.deltaTime, 0, 0); }

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
