using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuScript : MonoBehaviour
{
    public GameObject PauseMenu;
    // public GameObject crosshairCanvas;
    // public GameObject GUICanvas;
    // public GameObject tooltipCanvas;
    
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P) && !PauseMenu.activeSelf)
        {
            // crosshairCanvas.SetActive(false);
            // GUICanvas.SetActive(false);
            // tooltipCanvas.SetActive(false);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            PauseMenu.SetActive(true);
            Time.timeScale = 0f;
        }
        else if(Input.GetKeyDown(KeyCode.P) && PauseMenu.activeSelf)
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            PauseMenu.SetActive(false);
            Time.timeScale = 1;
        }
    }


}
