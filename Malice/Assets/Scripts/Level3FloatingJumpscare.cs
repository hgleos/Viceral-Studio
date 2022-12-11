using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations.Rigging;

public class Level3FloatingJumpscare : MonoBehaviour
{
    public AudioSource Scream;
    public GameObject enemy;
    bool checkIfPlayed = false;
    public Rig RigLayer;
    public GameObject trigger;

    // Start is called before the first frame update
    void Start()
    {
        enemy.SetActive(false);
    }

    void Update()
    {
        RigLayer.weight = Random.Range(0.10f, 1.0f);
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
