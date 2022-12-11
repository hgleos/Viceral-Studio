using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class OpeningTextScene1 : MonoBehaviour
{
    public GameObject Player;
    //public GameObject FadeScreenIn;
    public GameObject TextBox;
    // Start is called before the first frame update
    void Start()
    {
        Player.GetComponent<FirstPersonController>().enabled = false;
        StartCoroutine(ScenePlayer());
    }

    IEnumerator ScenePlayer()
    {
        yield return new WaitForSeconds(3f);
        //FadeScreenIn.SetActive(false);
        TextBox.GetComponent<Text>().text = "Where am I...?";
        yield return new WaitForSeconds(3f);
        TextBox.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(1f);
        TextBox.GetComponent<Text>().text = "My head hurts...";
        yield return new WaitForSeconds(3f);
        TextBox.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(1f);
        TextBox.GetComponent<Text>().text = "...I can't remember anything.";
        yield return new WaitForSeconds(3f);
        TextBox.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(1f);
        // TextBox.GetComponent<Text>().text = "I need to get out of this place.";
        // yield return new WaitForSeconds(3f);
        // TextBox.GetComponent<Text>().text = "";
        // yield return new WaitForSeconds(1f);
        TextBox.GetComponent<Text>().text = "Looks like a flashlight on that couch...";
        yield return new WaitForSeconds(3f);
        TextBox.GetComponent<Text>().text = "";
        Player.GetComponent<FirstPersonController>().enabled = true;        
    }
}
