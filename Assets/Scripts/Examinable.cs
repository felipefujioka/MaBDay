using UnityEngine;
using UnityEngine.PlayerLoop;

public class Examinable : CameraChange
{
    private Vector3 originalPosition;
    private Vector3 originalRotation;

    public Vector3 PositionOffset;

    public override void Start()
    {
        base.Start();
        originalPosition = transform.position;
        originalRotation = transform.eulerAngles;
    }

    public override void Click()
    {
        base.Click();
        transform.position = transform.position + PositionOffset;
    }

    public override void Update()
    {
        if (activated && Input.GetKeyDown(KeyCode.Escape))
        {
            CameraToActivate.SetActive(false);
            activated = false;
            ChangeActivation(false);
            camera.cullingMask |= LayerMask.GetMask("Character");
            StartCoroutine(EnableCollider());
            ExtraDismiss();
        }
    }

    public override void ExtraDismiss()
    {
        transform.position = originalPosition;
        transform.eulerAngles = originalRotation;
    }
}
