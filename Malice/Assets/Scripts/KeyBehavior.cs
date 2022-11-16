using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyBehavior : MonoBehaviour
{
    [SerializeField] GameObject key;

    private RaycastHit hit;
    public bool hasLevelOnekey = false;
    private bool done = false;
    // Update is called once per frame
    void Update()
    {
        if (!done)
        {
            if(hasLevelOnekey)
            {
                key.SetActive(false);
                done = true;
            }
        }
            
    }
}
