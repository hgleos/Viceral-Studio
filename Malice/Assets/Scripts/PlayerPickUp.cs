using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPickUp : MonoBehaviour
{
    [SerializeField] private LayerMask pickableLayerMask;
    [SerializeField] private LayerMask interactiveLayerMask;
    [SerializeField] private Transform playerCameraTransform;
    [SerializeField] GameObject pickUpUI;
    [SerializeField] GameObject interactUI;
    [SerializeField] [Min(1)] private float pickUpRange = 3;
    [SerializeField] ShowHide showHide;
    [SerializeField] KeyBehavior keyBehavior;

    private RaycastHit hit;

    private void Update()
    {
        if (hit.collider != null)
        {
            pickUpUI.SetActive(false);
            interactUI.SetActive(false);
        }
        
        if(Physics.Raycast(playerCameraTransform.position, playerCameraTransform.forward, out hit, pickUpRange, pickableLayerMask))
        {
            pickUpUI.SetActive(true);
            if(Input.GetKeyDown(KeyCode.E))
            {
                PickUp(hit.collider.tag);
            }
        }

        else if(Physics.Raycast(playerCameraTransform.position, playerCameraTransform.forward, out hit, pickUpRange, interactiveLayerMask))
        {
            interactUI.SetActive(true);
            if(Input.GetKeyDown(KeyCode.E))
            {
                Interact();
            }
        }

    }

    private void PickUp(string tag)
    {
        if (tag == "Flashlight")
        {
            showHide.hasFlashLight = true;

        }
        else if (tag == "LevelOneKey")
            keyBehavior.hasLevelOnekey = true;

    }

    private void Interact()
    {
        print("interact");
    }
}
