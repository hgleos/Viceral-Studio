using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KeyBehavior : MonoBehaviour
{
    [SerializeField] GameObject key;

    private RaycastHit hit;
    public bool hasLevelOnekey = false;
    private bool done = false;
    // Update is called once per frame
    void Update()
    {
        if (!done)
        {
            if(hasLevelOnekey)
            {
                key.SetActive(false);
                done = true;
                // This is what loads the Death Scene, move it to your script and I guess it will get triggered when the player is hit the second time.
                // SceneManager.LoadScene(2);
            }
        }
            
    }
}
