using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingCredits : MonoBehaviour
{
    [SerializeField] GameObject skipUI;

    void Start()
    {
        StartCoroutine(EndingCoroutine());
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void skip()
    {
        SceneManager.LoadScene(0);
    }

    IEnumerator EndingCoroutine()
    {
        yield return new WaitForSeconds(3.0f);
        skipUI.SetActive(true);
        yield return new WaitForSeconds(55.0f);
        SceneManager.LoadScene(0);
    }
}
