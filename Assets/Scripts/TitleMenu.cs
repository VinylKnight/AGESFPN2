using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleMenu : MonoBehaviour
{
    [SerializeField]
    private string gameSceneName;
    [SerializeField]
    private GameObject creditsMenuPanel;
    [SerializeField]
    private GameObject titleMenuPanel;

    

    public GameObject CreditsMenuPanel => creditsMenuPanel;
    public GameObject TitleMenuPanel => titleMenuPanel;

    public void LoadGameScene()
    {
        SceneManager.LoadScene(gameSceneName);
    }
    public void ShowCredits()
    {
        PanelState.IsCreditsEnabled = true;
        creditsMenuPanel.SetActive(PanelState.IsCreditsEnabled);

    }
    public void ShowTitle()
    {
        PanelState.IsTitleEnabled = true;
        titleMenuPanel.SetActive(PanelState.IsTitleEnabled);
    }
    public void ExitGame()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
}
