using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;
using UnityEngine.UIElements;

public class NumberWatcher : MonoBehaviour
{
    public string Key;
    public List<NumberChange> NumberChanges;
    public List<int> Numbers;

    public GameObject ToActivate;

    private void Update()
    {
        bool solved = true;

        for (int i = 0; i < NumberChanges.Count; i++)
        {
            if (NumberChanges[i].GetValue() != Numbers[i])
            {
                solved = false;
                break;
            }
        }

        if (solved)
        {
            if (ToActivate != null)
            {
                ToActivate.SetActive(true);    
            }

            KeyController.Instance.Activate(Key);

        }
    }
}
