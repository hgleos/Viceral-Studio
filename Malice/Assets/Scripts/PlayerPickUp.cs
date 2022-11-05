using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickUp : MonoBehaviour
{
    [SerializeField] private LayerMask pickableLayerMask;
    [SerializeField] private Transform playerCameraTransform;
    [SerializeField] GameObject pickUpUI;
    [SerializeField] [Min(1)] private float pickUpRange = 3;
    [SerializeField] ShowHide showHide;

    private RaycastHit hit;

    private void Update()
    {
        if (hit.collider != null)
            pickUpUI.SetActive(false);

        if(Physics.Raycast(playerCameraTransform.position, playerCameraTransform.forward, out hit, pickUpRange, pickableLayerMask))
        {
            pickUpUI.SetActive(true);
            if(Input.GetKeyDown(KeyCode.E))
            {
                PickUp();
            }
        }
    }

    private void PickUp()
    {
        showHide.hasFlashLight = true;
    }
}
