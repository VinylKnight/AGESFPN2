using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Detects when the player presses the Interact Button while looking at an IInteractive
/// and then calls that IInteractive's interactWith method
/// </summary>
public class InteractWithLookedAt : MonoBehaviour
{
    [SerializeField]
    private DetectLookedAtInteractiveObjects detectLookedAtInteractiveObjects;
   // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Interact") && detectLookedAtInteractiveObjects != null)
        {
            Debug.Log("Player pressed the interact button.");
        }
    }
}
