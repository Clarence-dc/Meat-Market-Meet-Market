using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController1 : MonoBehaviour
{
    public Rigidbody ourQuis; // the Quis has a rigid body attached
    public Transform ourPos; // the position where the Quis will appear!
    Rigidbody quisInstance;
    // Start is called before the first frame update
    void Start()
    {
       // Single-axis movements 

}

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = Vector3.zero;
        


        if (Input.GetKey(KeyCode.UpArrow))
        {
            { transform.Translate(0, 0, 12 * Time.deltaTime); }
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            { transform.Translate(0, 0, -12 * Time.deltaTime); }
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            { transform.Translate(-12 * Time.deltaTime, 0, 0); }
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            { transform.Translate(12 * Time.deltaTime, 0, 0); }
        }

        
    }
}
