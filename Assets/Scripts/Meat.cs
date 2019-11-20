using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Meat : MonoBehaviour
{
    [SerializeField]
    private Text pickUpText;

    public AudioSource Bang;
    public AudioSource Bell;
    public AudioSource GetOut;
    public AudioSource Defeat;

    private bool pickUpAllowed;


    // Use this for initialization
    private void Start()
    {
        pickUpText.gameObject.SetActive(false);   
    }

    // Update is called once per frame
    private void Update()
    {
        if (pickUpAllowed && Input.GetKeyDown(KeyCode.Space))
        {
            pickUp();
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            pickUpText.gameObject.SetActive(true);
            pickUpAllowed = true;

        }

    }
    public void PlayBang()
    {
        Bang.Play();
    }
    private void OnTriggerExit(Collider other)
    {
        pickUpText.gameObject.SetActive(false);
        pickUpAllowed = false;

    }



    private void pickUp()
    {
        Debug.Log("I'm being picked up");
        GameObject PlayerObject = GameObject.Find("Player");
        transform.SetParent(PlayerObject.transform);
        PlayerObject.GetComponent<PlayerController>().hasMeat = true;
        pickUpAllowed = false;
        pickUpText.gameObject.SetActive(false);
        GetComponent<Collider>().enabled = false;
        Bang.Play();

}

   
    
}
