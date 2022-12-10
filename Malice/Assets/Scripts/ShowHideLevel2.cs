using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations.Rigging;

public class ShowHideLevel2 : MonoBehaviour
{
    public bool hasFlashLight;
    public GameObject FlashlightInHand;
    public GameObject SpotLight;
    public GameObject flashlightUI;
    public Rig ArmRigLayer;
    public Rig FingerRigLayer;

    bool done = false; // used to stop updating
    bool spotlightBool = false;
    // Update is called once per frame
    void Update()
    {
        hasFlashLight = true;
        if (!done)
        {
            if(hasFlashLight)
            {
                spotlightBool = !spotlightBool;
                FlashlightInHand.SetActive(true);
                SpotLight.SetActive(spotlightBool);
                ArmRigLayer.weight = 1;
                FingerRigLayer.weight = 1;
                flashlightUI.SetActive(true);
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
