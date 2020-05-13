using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGate : InteractiveObject
{
    [Tooltip("Assigning a required item here will set the gate. If the player has the required item in their inventory, they can utilize the set gate.")]
    [SerializeField]
    private InventoryObject key;

    [Tooltip("If this is checked, the required item will be removed from the player's inventory when the gate is utilized.")]
    [SerializeField]
    private bool consumesKey;

    [Tooltip("The text that displays when the player looks at the gate while it needs a required item.")]
    [SerializeField]
    private string requiredItemDisplayText = "Requires designated object";

    [Tooltip("Play this audio clip when the player interacts with the set gate without owning the required item.")]
    [SerializeField]
    private AudioClip lockedAudioClip;

    [Tooltip("Play this audio clip when the player utilizes the set gate.")]
    [SerializeField]
    private AudioClip openAudioClip;

    [Tooltip("GameObject that will be toggled between active and nonactive.")]
    [SerializeField]
    private GameObject objectToToggle;

    [Tooltip("GameObject that will be toggled between active and nonactive.")]
    [SerializeField]
    private GameObject objectToToggle2;

    [Tooltip("GameObject that will be toggled between active and nonactive.")]
    [SerializeField]
    private GameObject objectToToggle3;

    //public override string DisplayText => isLocked ? lockedDisplayText : base.DisplayText;

    public override string DisplayText
    {
        get
        {
            string toReturn;
            if (isLocked)
            {
                toReturn = hasKey ? $"Use {key.ObjectName}" : requiredItemDisplayText;
            }
            else
            {
                toReturn = base.DisplayText;
            }
            return toReturn;
        }
    }

    private bool hasKey => PlayerInventory.InventoryObjects.Contains(key);
    private bool isLocked;
    private bool isOpen;
    private InventoryMenu inventoryMenu;
    /// <summary>
    /// Using a constructor here to initialize displayText in the editor.
    /// </summary>
    public ItemGate()
    {
        displayText = nameof(ItemGate);
    }

    protected override void Awake()
    {
        base.Awake();
        InitializeIsLocked();
        inventoryMenu = FindObjectOfType<InventoryMenu>();
    }

    private void InitializeIsLocked()
    {
        if (key != null)
        {
            isLocked = true;
        }
    }

    public override void InteractWith()
    {
        if (!isOpen)
        {
            if (isLocked && !hasKey)
            {
                audioSource.clip = lockedAudioClip;
            }
            else // if the door isn't locked, or if it's locked and we have the key...
            {
                audioSource.clip = openAudioClip;
                base.InteractWith();
                objectToToggle.SetActive(!objectToToggle.activeSelf);
                objectToToggle2.SetActive(!objectToToggle2.activeSelf);
                objectToToggle3.SetActive(!objectToToggle3.activeSelf);
                displayText = string.Empty;
                isOpen = true;
                UnlockGate();
            }
            base.InteractWith();// This plays a sound effect!
        }

    }

    private void UnlockGate()
    {
        isLocked = false;
        if (key != null && consumesKey)
            PlayerInventory.InventoryObjects.Remove(key);
        inventoryMenu.DestroyItemFromInventory(key);
    }
}
