using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyBehavior : MonoBehaviour
{
    [SerializeField] private LayerMask pickableLayerMask;
    [SerializeField] private Transform playerCameraTransform;
    [SerializeField] GameObject pickUpUI;
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
