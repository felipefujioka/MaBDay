using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformRotation : MonoBehaviour
{
    public float Speed = 20f;
    
    private void OnMouseDrag()
    {
        float mouseX = Input.GetAxis("Mouse X") * Speed * Mathf.Rad2Deg;
        float mouseY = Input.GetAxis("Mouse Y") * Speed * Mathf.Rad2Deg;
        
        transform.Rotate(Vector3.up, -mouseX, Space.World);
        transform.Rotate(Vector3.right, mouseY, Space.World);
    }
}
