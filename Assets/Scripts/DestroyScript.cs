using UnityEngine;
using System.Collections;

public class DestroyScript : MonoBehaviour
{
    public GameObject objToDestroy;


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
            Destroy(objToDestroy);

    }

}
