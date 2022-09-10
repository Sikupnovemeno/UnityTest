using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Control : MonoBehaviour
{
    public enum RotationAxis
    {
        MouseX = 1,
        MouseY = 2
    } 

    public RotationAxis axes = RotationAxis.MouseX;
    public float minimumVert = -89.0f;
    public float maximumVert = 89.0f;

    public float sensHorizontal = 5.0f;
    public float sensVertical = 5.0f;
    public float _rotationX = 0;



    // Update is called once per frame
    void Update()
    {
        if(axes == RotationAxis.MouseX)
        {
            transform.Rotate(0, Input.GetAxis("Mouse X") * sensHorizontal, 0);
        }else if(axes == RotationAxis.MouseY)
        {
            _rotationX -= Input.GetAxis("Mouse Y") * sensVertical;
            _rotationX = Mathf.Clamp(_rotationX, minimumVert, maximumVert); // Clamps the vertical angle within the min and max limites (90 degress)

            float rotationY = transform.localEulerAngles.y;

            transform.localEulerAngles = new Vector3(_rotationX, rotationY, 0);
            
        }
        
    }
}
