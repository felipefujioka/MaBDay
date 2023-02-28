using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class DestroyOnClick : MonoBehaviour
{

    public int NumberOfClick = 3;

    private int clicked = 0;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            clicked++;
            if (clicked == NumberOfClick)
            {
                Destroy(gameObject);
            }
        }
    }
}
