using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;

public class CameraChange : AClickable
{
    public GameObject CameraToActivate;
    protected bool activated;
    protected Camera camera;
    private Collider collider;

    public virtual void Start()
    {
        camera = Camera.main;
        collider = GetComponent<Collider>();
    }

    public override void Click()
    {
        if (!activated)
        {
            CameraToActivate.SetActive(true);
            activated = true;    
            ChangeActivation(true);
            camera.cullingMask &= ~LayerMask.GetMask("Character");
            collider.enabled = false;
        }
    }

    public virtual void Update()
    {
        if (activated && Input.GetMouseButtonDown(0))
        {
            CameraToActivate.SetActive(false);
            activated = false;
            ChangeActivation(false);
            camera.cullingMask |= LayerMask.GetMask("Character");
            StartCoroutine(EnableCollider());
            ExtraDismiss();
        }
    }

    public virtual void ExtraDismiss()
    {
    }

    protected IEnumerator EnableCollider()
    {
        yield return new WaitForSeconds(0.5f);
        collider.enabled = true;
    }
}
