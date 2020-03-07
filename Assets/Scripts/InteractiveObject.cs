using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof (AudioSource))]
public class InteractiveObject : MonoBehaviour, IInteractive
{
    [SerializeField]
    private AudioSource audioSource;
    [SerializeField]
    private string displayText = nameof(InteractiveObject);

    public string DisplayText => displayText;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void interactWith()
    {
        try
        {
         audioSource.Play();
        }
        catch(System.Exception)
        {
         throw new System.Exception("Missing AudioSource: Interactive objects require an AudioSource component.");
        }
        Debug.Log($"Player just interacted with {gameObject.name}.");
    }
}
