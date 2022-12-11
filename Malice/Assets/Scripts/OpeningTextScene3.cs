using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpeningTextScene3 : MonoBehaviour
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
        TextBox.GetComponent<Text>().text = "What was that thing?";
        yield return new WaitForSeconds(3f);
        TextBox.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(1f);
        TextBox.GetComponent<Text>().text = "I've got to be close to the exit by now...";
        yield return new WaitForSeconds(3f);
        TextBox.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(1f);
        TextBox.GetComponent<Text>().text = "...the voices are getting louder...";
        yield return new WaitForSeconds(3f);
        TextBox.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(1f);
        TextBox.GetComponent<Text>().text = "I NEED to get out of this damn place.";
        yield return new WaitForSeconds(3f);
        TextBox.GetComponent<Text>().text = "";  
    }
}
