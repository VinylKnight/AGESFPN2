using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenLink : MonoBehaviour
{
    public void OpenSound()
    {
        Application.OpenURL("https://freesound.org/");
    }

    public void OpenSnapsAsset()
    {
        Application.OpenURL("https://assetstore.unity.com/packages/3d/environments/snaps-prototype-office-137490");
    }

    public void OpenMusic()
    {
        Application.OpenURL("https://incompetech.com/music/");
    }

    public void OpenPurplePlanet()
    {
        Application.OpenURL("https://www.purple-planet.com/");
    }

}
