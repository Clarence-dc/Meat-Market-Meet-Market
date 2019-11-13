using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioOnSpot : MonoBehaviour
{
    public AudioSource Bang;
    public AudioSource Bell;
    public AudioSource GetOut;
    public AudioSource Defeat;

    public void PlayBang()
    {
        Bang.Play();
    }

    private void OnCollisionEnter(Collision collision)
    {
        Bang.Play();
    }
}
