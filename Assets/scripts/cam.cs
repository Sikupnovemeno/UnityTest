using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cam : MonoBehaviour
{

    public Animator animator;
    public Animator anim;
    private bool isOn = false;
    private bool isOff = true;

    private bool isBefore = false;
    private bool isNext = false;

    private void OnMouseDown() 
    {

        if(Input.GetMouseButtonDown(0))
        {
            isOn = !isOn;
            animator.SetBool("on", true);
            animator.SetBool("off", false);
        }
        

    }

    
    
    private void Update() 
    {

        OnMouseDown();


        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            print("before");
            isBefore = !isBefore;
            anim.SetBool("next", false);
            anim.SetBool("before", true);
        }
        else 
        {
            anim.SetBool("next", false);
            anim.SetBool("before", false);
        }
        
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            print("next");
            isNext = !isNext;
            anim.SetBool("next", true);
            anim.SetBool("before", false);
        }
        else 
        {
            anim.SetBool("next", false);
            anim.SetBool("before", false);
        }

        if(Input.GetKeyDown(KeyCode.E))
        {
            
        }
        
        
    }
        
}
