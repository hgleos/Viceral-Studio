using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpWithoutCamera : MonoBehaviour
{
    public AudioSource Scream;
    public GameObject enemy;
    public GameObject trigger;
    bool checkIfPlayed = false;


    // Start is called before the first frame update
    void Start()
    {
        enemy.SetActive(false);
    }

    void OnTriggerEnter()
    {
        if (checkIfPlayed==false)
        {
         Scream.Play();
        }
        checkIfPlayed=true;
        enemy.SetActive(true);
        StartCoroutine(EndJump());
    }

    IEnumerator EndJump()
    {
        yield return new WaitForSeconds(1.5f);
        enemy.SetActive(false);
        trigger.SetActive(false);
    }

}
