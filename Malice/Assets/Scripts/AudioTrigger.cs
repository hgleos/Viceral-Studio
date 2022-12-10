using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTrigger : MonoBehaviour
{
    public AudioSource noise;
    bool checkIfPlayed = false;

    void OnTriggerEnter()
    {
        if (checkIfPlayed==false)
        {
            noise.Play();
        }
        checkIfPlayed=true;
    }

}
