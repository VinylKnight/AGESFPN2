using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


/// <summary>
/// The UI text displays info on the currently looked at interactive IInteractive
/// </summary>
public class LookedtAtInteractiveDisplayText : MonoBehaviour
{
    private IInteractive lookedAtInteractive;
    private Text displayText;

    private void Awake()
    {
        displayText = GetComponent<Text>();   
    }
    private void UpdateDisplayText()
    {
        if (lookedAtInteractive != null)
            displayText.text = lookedAtInteractive.DisplayText;
        else
            displayText.text = string.Empty;
    }

    private void OnLookedAtInteractiveChanged()
    {
        UpdateDisplayText();
    }

    private void OnEnable()
    {
        DetectLookedAtInteractiveObjects.LookedAtInteractiveChanged += OnLookedAtInteractiveChanged;
    }

    private void OnDisable()
    {
        
    }
}
