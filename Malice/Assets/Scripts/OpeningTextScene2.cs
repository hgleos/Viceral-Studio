using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class OpeningTextScene2 : MonoBehaviour
{
    public GameObject TextBox;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ScenePlayer());
    }

    IEnumerator ScenePlayer()
    {
        yield return new WaitForSeconds(1f);
        TextBox.GetComponent<Text>().text = "I keep hearing voices in my head...";
        yield return new WaitForSeconds(3f);
        TextBox.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(1f);
        TextBox.GetComponent<Text>().text = "Am I going crazy?";
        yield return new WaitForSeconds(3f);
        TextBox.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(1f);
        TextBox.GetComponent<Text>().text = "I don't think I'm alone...";
        yield return new WaitForSeconds(3f);
        TextBox.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(1f);
        TextBox.GetComponent<Text>().text = "...there has to be another door somewhere.";
        yield return new WaitForSeconds(3f);
        TextBox.GetComponent<Text>().text = "";  
    }
}
