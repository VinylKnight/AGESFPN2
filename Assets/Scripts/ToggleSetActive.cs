using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleSetActive : InteractiveObject
{
    [Tooltip("GameObject that will be toggled between active and nonactive.")]
    [SerializeField]
    private GameObject objectToToggle;
    [Tooltip("Can the player use this object more than once")]
    [SerializeField]
    private bool isReusable = true;

    private bool hasBeenUsed = false;

    /// <summary>
    /// Toggel the activeSelf value for the objectToToggle when the player interacts with this item.
    /// </summary>
    public override void InteractWith()
    {
        if (isReusable || !hasBeenUsed)
        {
            base.InteractWith();
            objectToToggle.SetActive(!objectToToggle.activeSelf);
            hasBeenUsed = true;
            if (!isReusable)
                displayText = string.Empty;
        }
    }
}
