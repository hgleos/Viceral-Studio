using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFlicker : MonoBehaviour
{
    // Start is called before the first frame update

    public Light light1;

    public float minimumTime;
    public float maximumTime;
    public float timer;

    void Start()
    {
        timer = Random.Range(minimumTime, maximumTime);        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        if (timer <= 0)
        {
            light1.enabled = !light1.enabled;
            timer = Random.Range(minimumTime, maximumTime);
        }
    }
}
