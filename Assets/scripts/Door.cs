using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{

    public Animator animator;

    private bool isOpen = true;
    private bool isClose = false;

  

    private void OnMouseDown()
    {
        if(Input.GetMouseButtonDown(0))
        {
            isClose = !isClose;
            animator.SetBool("open", false);
            animator.SetBool("close", true);

        }
     

    }
    private void OnMouseUp()
    {
        if (Input.GetMouseButtonUp(0))
        {
            isOpen = !isOpen;
            animator.SetBool("open", true);
            animator.SetBool("close", false);
        }
    }




















}
