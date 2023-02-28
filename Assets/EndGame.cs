using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    public CanvasGroup CanvasGroup;
    public Timer Timer;
    
    void Start()
    {
        Timer.Running = false;

        StartCoroutine(FadeAway());
    }

    private IEnumerator FadeAway()
    {
        float time = 3f;

        float target = 1;

        while (CanvasGroup.alpha < target)
        {
            CanvasGroup.alpha += Time.deltaTime / time;
            yield return null;
        }

        SceneManager.LoadScene("EndScene");
    }
}
