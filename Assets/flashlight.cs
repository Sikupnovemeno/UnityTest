using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flashlight : MonoBehaviour
{
    public Animator anim;

    private bool isOn = false;
    private bool isOff = true;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            isOn = !isOn;
            anim.SetBool("on", true);
            anim.SetBool("off", false);

        }
        else
        {
            isOff = !isOff;
            anim.SetBool("off", true);
            anim.SetBool("on", false);
        }
        
    }
}
