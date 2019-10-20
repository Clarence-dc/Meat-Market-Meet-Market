using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Meat : MonoBehaviour
{
    [SerializeField]
    private Text pickUpText;

    private bool pickUpAllowed;

    private bool canThrow;
    private bool moving;


    // Use this for initialization
    private void Start()
    {
        pickUpText.gameObject.SetActive(false);   
    }

    // Update is called once per frame
    private void Update()
    {
        if (pickUpAllowed && Input.GetKeyDown(KeyCode.Space))
            pickUp();
        if (canThrow && Input.GetKeyDown(KeyCode.T))
            throwDrop();
        if (moving)
            transform.Translate(transform.forward * Time.deltaTime);   
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            pickUpText.gameObject.SetActive(true);
            pickUpAllowed = true;

        }

    }

  

    private void pickUp()
    {
        Debug.Log("I'm being picked up");
        GameObject PlayerObject = GameObject.Find("Player");
        transform.SetParent(PlayerObject.transform);
        pickUpAllowed = false;
        pickUpText.gameObject.SetActive(false);
        canThrow = true;
    }

    private void throwDrop()
    {
        transform.SetParent(null);
        moving = true;
        
    }

}
