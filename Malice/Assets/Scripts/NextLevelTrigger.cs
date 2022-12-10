using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelTrigger : MonoBehaviour
{
   void OnTriggerEnter()
   {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
   }
}
