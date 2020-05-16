using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;

public class TrialContext : MonoBehaviour
{
    [Tooltip("Place in the UI for displaying info about the selected inventory item.")]
    [SerializeField]
    private Text descriptionAreaText;

    [SerializeField]
    private int readTime;

    public int ReadTime => readTime;
    private CanvasGroup canvasGroup;
    private RigidbodyFirstPersonController rigidbodyFirstPersonController;
    private void Awake()
    {
        canvasGroup = GetComponent<CanvasGroup>();
        rigidbodyFirstPersonController = FindObjectOfType<RigidbodyFirstPersonController>();
        ShowInterviewContext();
        StartCoroutine(ContextReadingTime());
        HideInterviewContext();
    }
   
    private IEnumerator ContextReadingTime()
    {
        Debug.Log("Start Waiting");
        yield return new WaitForSeconds(ReadTime);
        Debug.Log("Done Waiting");
        
    }
    private void ShowInterviewContext()
    {
        canvasGroup.alpha = 1;
        canvasGroup.interactable = true;
        rigidbodyFirstPersonController.enabled = false;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    private void HideInterviewContext()
    {
        canvasGroup.alpha = 0;
        canvasGroup.interactable = false;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        rigidbodyFirstPersonController.enabled = true;
    }
}
