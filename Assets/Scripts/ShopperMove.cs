using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopperMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    { }
         private bool dirRight = true;
    public float speed = 2.0f;

    // Update is called once per frame
    void Update()
    {
        if (dirRight)
            transform.Translate(Vector3.right * 3 * Time.deltaTime);
        else
            transform.Translate(-Vector3.right * 3 * Time.deltaTime);

        if (transform.position.x >= 4.0f)
        {
            dirRight = false;
        }

        if (transform.position.x <= -4)
        {
            dirRight = true;
        }
    }
}
