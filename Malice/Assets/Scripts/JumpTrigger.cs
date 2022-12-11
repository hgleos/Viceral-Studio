using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpTrigger : MonoBehaviour
{
   public AudioSource Scream;
   public GameObject RImage;
   public GameObject JumpCam;
   public GameObject FlashImg;
   bool checkIfPlayed = false;


   void Start()
   {
        JumpCam.SetActive(false);
        RImage.SetActive(false);
   }


   void OnTriggerEnter()
   {
        if (checkIfPlayed==false)
        {
         Scream.Play();
        }
        checkIfPlayed=true;
        RImage.SetActive(true);
        JumpCam.SetActive(true);
        FlashImg.SetActive(true);
        StartCoroutine(EndJump());
   }

    IEnumerator EndJump()
    {
        yield return new WaitForSeconds(1.5f);
        RImage.SetActive(false);
        JumpCam.SetActive(false);
        FlashImg.SetActive(false);
    }

}
