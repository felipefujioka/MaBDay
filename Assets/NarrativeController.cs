using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NarrativeController : MonoBehaviour
{
    public float TimeInSeconds;

    public GameObject ToActivateOnEnd;
    
    public ScrollRect ScrollView;
    public AudioSource AudioSource;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(NarrativeRoutine());
    }

    private IEnumerator NarrativeRoutine()
    {
        yield return new WaitForSeconds(3f);
        
        AudioSource.Play();

        while (ScrollView.verticalNormalizedPosition > 0f)
        {
            ScrollView.verticalNormalizedPosition -= Time.deltaTime / TimeInSeconds;
            yield return null;
        }
        
        yield return new WaitForSeconds(2f);

        ToActivateOnEnd.SetActive(true);
    }
}
