using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float sensitivity = 0.5f;
    Vector3 mouseReference;
    Vector3 mouseOffset;
    Vector3 rotation = Vector3.zero;
    bool isRotating;

    void Start()
    {
        
    }

    
    void Update()
    {
        if (isRotating)
          {
        //       // offset
        //       mouseOffset = (Input.mousePosition - mouseReference);


        //       // apply rotation
        //       rotation.x = -(mouseReference.x + mouseOffset.x) * sensitivity;
        //       //rotation.y = -(mouseReference.y + mouseOffset.y) * sensitivity;
        //       //rotation.z = -(mouseReference.z + mouseOffset.z) * sensitivity;

        //       // rotate
        //       transform.Rotate(rotation); // store new mouse position
              
              
        //       mouseReference = Input.mousePosition;

        //       //transform.Rotate(_rotation);
        //       transform.eulerAngles += rotation;
        //       // store mouse
        
                transform.Rotate((Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime), -(Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime), 0, Space.World);
          }

        
        
    }

    private void OnMouseDown() 
    {
        // rotating flag
        isRotating = true;
  
        // store mouse position
        //mouseReference = Input.mousePosition;
    }

    private void OnMouseUp() 
    {
        isRotating = false;
    }

}
