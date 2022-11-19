using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] GameObject playUI;
    [SerializeField] GameObject quitUI;

    void Start()
    {
        StartCoroutine(MainMenuCoroutine());
    }

    public void playGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void quitGame()
    {
        Application.Quit();
    }

    IEnumerator MainMenuCoroutine()
    {
        yield return new WaitForSeconds(3.5f);
        playUI.SetActive(true);
        quitUI.SetActive(true);
    }
}
