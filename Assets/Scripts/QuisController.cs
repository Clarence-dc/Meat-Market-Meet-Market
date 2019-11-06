using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuisController : MonoBehaviour
{
    float duration;
    // Start is called before the first frame update
    void Start()
    {
        duration = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        duration = duration - Time.deltaTime;
        if (duration < 0)
        {
            Destroy(gameObject);
        }
        {

        }
    }
}
