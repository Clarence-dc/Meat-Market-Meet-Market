using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject PlayerObject = GameObject.Find("Player");
        Vector3 PlayerPosition = PlayerObject.transform.position;
        transform.position= (Vector3.MoveTowards(transform.position, PlayerPosition, 4 * Time.deltaTime));
        Debug.Log(PlayerPosition);
        Debug.Log(transform.position);
    }
}
