using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate2DTransformable : MonoBehaviour
{
    private void OnMouseDrag()
    {
        float mouseY = Input.GetAxis("Mouse Y");
        
        transform.RotateAround(transform.forward, mouseY);
    }
}
