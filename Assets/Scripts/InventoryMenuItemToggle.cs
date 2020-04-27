using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryMenuItemToggle : MonoBehaviour
{
    private InventoryObject associatedInventoryObject;

    [Tooltip("The image component used to show the associated object's icon.")]
    [SerializeField]
    private Image iconImage;

    public InventoryObject AssociatedInventoryObject
    {
        get { return associatedInventoryObject; }
        set
        {
            associatedInventoryObject = value;
            iconImage.sprite = associatedInventoryObject.Icon;
        }
    }

    private void Awake()
    {
        
    }
}
