using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScreen : MonoBehaviour
{
    [SerializeField] GameObject tryAgainUI;
    [SerializeField] GameObject quitUI;

    void Start()
    {
        StartCoroutine(DeathCoroutine());
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void playGame()
    {
        // SceneManager.LoadScene(1);
        SceneManager.LoadScene(PlayerPrefs.GetInt("CurrentLevel")); // This loads the level the player was on before the death screen
    }

    public void quitGame()
    {
        Application.Quit();
    }

    IEnumerator DeathCoroutine()
    {
        yield return new WaitForSeconds(1.5f);
        tryAgainUI.SetActive(true);
        quitUI.SetActive(true);
    }
}
