using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ToggleCreditsScene : InteractiveObject
{
    
    public override void InteractWith()
    {
        SceneManager.LoadScene("TitleMenu");
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        base.InteractWith();    
    }
}
