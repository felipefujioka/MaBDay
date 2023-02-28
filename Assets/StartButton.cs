using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{

    public bool IsStart;
    
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(OnClick);
    }

    private void OnClick()
    {
        if (IsStart)
        {
            SceneManager.LoadScene("SampleScene");
        }
        else
        {
            Application.Quit();
        }
    }
}
