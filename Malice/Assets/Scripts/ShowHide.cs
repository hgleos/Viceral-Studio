using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations.Rigging;

public class ShowHide : MonoBehaviour
{
    public bool hasFlashLight;
    public GameObject FlashlightInHand;
    public GameObject SpotLight;
    public GameObject Flashlight;
    public Rig ArmRigLayer;
    public Rig FingerRigLayer;

    bool done = false; // used to stop updating
    bool spotlightBool = false;
    // Update is called once per frame
    void Update()
    {
        if (!done)
        {
            if(hasFlashLight)
            {
                FlashlightInHand.SetActive(true);
                Flashlight.SetActive(false);
                SpotLight.SetActive(!spotlightBool);
                ArmRigLayer.weight = 1;
                FingerRigLayer.weight = 1;
                done = true;
            }
            else
            {
                FlashlightInHand.SetActive(false);
                SpotLight.SetActive(false);
                ArmRigLayer.weight = 0;
                FingerRigLayer.weight = 0;
            }
        }

        if(hasFlashLight && Input.GetKeyDown(KeyCode.Q))
        {
            spotlightBool = !spotlightBool;
            SpotLight.SetActive(spotlightBool);
        }

    }
}
