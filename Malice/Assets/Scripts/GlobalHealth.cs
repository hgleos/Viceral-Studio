using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalHealth : MonoBehaviour
{
    public static int currentHealth = 20;
    public int internalHealth;
    
    void Update()
    {
        internalHealth = currentHealth;
    }
}
