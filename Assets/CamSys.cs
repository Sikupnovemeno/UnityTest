using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSys : MonoBehaviour
{

    public Animator Cam;
    public Animator cam2;

    private bool isOn = false;
    private bool isOff = true;
    private bool isNext = false;
    private bool isBefore = true;
   
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            isOn = !isOn;
            Cam.SetBool("on", true);
            Cam.SetBool("off", false);

        }
        else if(Input.GetKeyDown(KeyCode.Q))
        {
            isOff = !isOff;
            Cam.SetBool("on", false);
            Cam.SetBool("off", true);
        }

        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            isNext = !isNext;
            cam2.SetBool("next", true);
            cam2.SetBool("before", false);
            
        }
        else if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            isBefore = !isBefore;
            cam2.SetBool("before", true);
            cam2.SetBool("next", false);
        }
        else
        {
            cam2.SetBool("before", false);
            cam2.SetBool("next", false);
        }
    }

}
