using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenLink : MonoBehaviour
{
    public void OpenSound()
    {
        Application.OpenURL("https://freesound.org/");
    }

    public void OpenAsset()
    {
        Application.OpenURL("https://assetstore.unity.com/packages/3d/environments/sci-fi/sci-fi-styled-modular-pack-82913");
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
