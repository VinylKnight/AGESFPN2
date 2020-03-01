﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class will allow the character to detect interactive objects when they look at them.
/// </summary>
public class DetectLookedAtInteractiveObjects : MonoBehaviour
{
    [Tooltip("Starting point of raycast used to detect interactives")]
    [SerializeField]
    private Transform raycastOrigin;
    [Tooltip("How far from the raycastOrigin we will search for interactive elements")]
    [SerializeField]
    private float maxRange = 5.0f;

    // Update is called once per frame
    private void FixedUpdate()
    {
        Debug.DrawRay(raycastOrigin.position,raycastOrigin.forward*maxRange,Color.red);
        RaycastHit hitInfo;
        bool objectWasDetected = Physics.Raycast(raycastOrigin.position, raycastOrigin.forward, out hitInfo, maxRange);

        if (objectWasDetected)
        {
            Debug.Log ($"Player is looking at: {hitInfo.collider.gameObject.name}");
        }
    }
}