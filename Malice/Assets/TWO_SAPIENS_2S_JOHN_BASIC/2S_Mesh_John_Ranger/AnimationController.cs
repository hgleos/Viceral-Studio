using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public Animator anim;

    // // Start is called before the first frame update
    // void Start()
    // {
    //     anim.SetBool("walkingForward", false);
    //     anim.SetBool("walkingBackward", false);
    // }

    // Update is called once per frame
    void Update()
    {
        // anim.SetFloat("vertical", Input.GetAxis("Vertical"), 0.1f, Time.fixedDeltaTime);
        // anim.SetFloat("horizontal", Input.GetAxis("Horizontal"), 0.1f, Time.fixedDeltaTime);

            if (Input.GetAxis("Vertical") > 0.1 && Input.GetKey(KeyCode.LeftShift) || Input.GetAxis("Vertical") < -0.1 && Input.GetKey(KeyCode.LeftShift))
            {
                anim.SetBool("isRunning", true);
                anim.SetFloat("vertical", Input.GetAxis("Vertical"), 0.1f, Time.fixedDeltaTime);
                anim.SetFloat("horizontal", Input.GetAxis("Horizontal"), 0.1f, Time.fixedDeltaTime);
            }
            else if ((Input.GetAxis("Horizontal") > 0.1 || Input.GetAxis("Horizontal") < -0.1) && (Input.GetAxis("Vertical") < 0.1 || Input.GetAxis("Vertical") > -0.1) && Input.GetKey(KeyCode.LeftShift))
            {
                anim.SetBool("isStrafingFast", true);
                anim.SetFloat("vertical", Input.GetAxis("Vertical"), 0.1f, Time.fixedDeltaTime);
                anim.SetFloat("horizontal", Input.GetAxis("Horizontal"), 0.1f, Time.fixedDeltaTime);
            }
            // else if (Input.GetAxis("Vertical") < -0.1)
            // {
            //     anim.SetBool("walkingBackward", true);
            //     anim.SetFloat("horizontal", Input.GetAxis("Horizontal"));
            //     // if(Input.GetKey(KeyCode.LeftShift))
            //     // {
            //     //     anim.SetBool("isRunning", true);
            //     // }
            // }
            else
            {
                anim.SetBool("isRunning", false);
                anim.SetBool("isStrafingFast", false);
                anim.SetFloat("vertical", Input.GetAxis("Vertical"), 0.1f, Time.fixedDeltaTime);
                anim.SetFloat("horizontal", Input.GetAxis("Horizontal"), 0.1f, Time.fixedDeltaTime);
            }

    }
}
