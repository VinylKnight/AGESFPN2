using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof (AudioSource))]
public class InteractiveObject : MonoBehaviour, IInteractive
{
    [Tooltip("This is the text that will display in the UI when the player looks at this object in the world.")]
    [SerializeField]
    protected string displayText = nameof(InteractiveObject);

    public virtual string DisplayText => displayText;
    protected AudioSource audioSource;

    protected virtual void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public virtual void InteractWith()
    {
        try
        {
         audioSource.Play();
        }
        catch(System.Exception)
        {
         throw new System.Exception("Missing AudioSource component or audio clip: Interactive objects require an AudioSource component with an audioClip assigned.");
        }
        Debug.Log($"Player just interacted with {gameObject.name}.");
    }
}
