using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioSource Bang;
    public AudioSource Bell;
    public AudioSource GetOut;
    public AudioSource Defeat;

    public void PlayBang()
    {
        Bell.Play();
    }

    private void OnTriggerEnter(Collider other)
    {
        Bell.Play();
    }
}