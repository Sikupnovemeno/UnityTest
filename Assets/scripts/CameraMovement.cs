using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    private float yaw = 0.0f;
    private float pitch = 0.0f;
    private Rigidbody rb;

    public float sensitivity = 2.0f;
   
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
         
    }

    void OnApplicationFocus(bool ApplicationIsBack)
    {
        if (ApplicationIsBack == true)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }

    
    void Update()
    {

        Look();
        
    }

    private void Look()
    {
        pitch -= Input.GetAxis("Mouse Y") * sensitivity;
        pitch = Mathf.Clamp(pitch, -90.0f, 90.0f);
        yaw += Input.GetAxisRaw("Mouse X") * sensitivity;
        Camera.main.transform.localRotation = Quaternion.Euler(pitch, yaw, 0);
    }
}
