using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class RotatingPuzzle : MonoBehaviour
{
    public Transform Target;

    public GameObject ToActivate;

    private void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            if ((Target.eulerAngles.z < 3 && Target.eulerAngles.z > -3) || 
                (Target.eulerAngles.z > 357 && Target.eulerAngles.z < 363))
            {
                if (ToActivate != null)
                {
                    ToActivate.SetActive(true);
                    KeyController.Instance.Activate("collar");
                }
            }    
        }
    }
}
