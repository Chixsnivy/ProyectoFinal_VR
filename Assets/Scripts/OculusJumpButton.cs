using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(OVRPlayerController))]

public class OculusJumpButton : MonoBehaviour
{
    private float moveSpeedMultiplier = 3.0f;

    private OVRPlayerController characterController;

    private void Awake()
    {
        characterController = GetComponent<OVRPlayerController>();
        characterController.SetMoveScaleMultiplier(moveSpeedMultiplier);
    }

    void Update()
    {
        if (OVRInput.Get(OVRInput.Button.One))
        {
            characterController.Jump();
        }
    }
}

