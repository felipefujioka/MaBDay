using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;
using UnityEngine.AI;

public class GameController : MonoBehaviour
{
    private class DistanceComparer : IComparer<RaycastHit>
    {
        public int Compare(RaycastHit x, RaycastHit y)
        {
            return x.distance > y.distance ? 1 : -1;
        }
    }
    
    public  NavMeshAgent CharacterAgent;
    private Camera camera;
    public Animator CharacterAnimator;
    public AudioSource StepAudioSource;
    
    RaycastHit[] hits = new RaycastHit[20];
    private int mask;
    private DistanceComparer comparer;
    private static readonly int Speed = Animator.StringToHash("Speed");

    private void Start()
    {
        camera = Camera.main;
        mask = LayerMask.GetMask("Floor", "Clickable");
        comparer = new DistanceComparer();
    }

    void Update()
    {
        CharacterAnimator.SetFloat(Speed, CharacterAgent.velocity.magnitude);

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Clicked");
            Vector3 screenPosition = Input.mousePosition;
            Ray ray = camera.ScreenPointToRay(screenPosition);

            int hitCount = Physics.RaycastNonAlloc(ray, hits, 20, mask);

            if (hitCount == 0) return;
            
            Array.Sort(hits, 0, hitCount, comparer);

            RaycastHit hit = hits[0];

            if (hit.IsFloor())
            {
                CharacterAgent.ResetPath();
                CharacterAgent.SetDestination(hit.point);
            } 
            else if (hit.IsClickable())
            {
                AClickable clickable = hit.collider.gameObject.GetComponent<AClickable>();
                if (clickable != null)
                {
                    clickable.Click();    
                }
            }
        }    
    }
}
