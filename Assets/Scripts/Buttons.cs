using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    /*
    [SerializeField] private string MainMenu;
    [SerializeField] private string StartGame;
    [SerializeField] private string SettingsButton;
    [SerializeField] private string QuitGameButton;
    [SerializeField] private string BackButton;
    [SerializeField] private string AudioOptionsButton;
    [SerializeField] private string AreYouSure;
    [SerializeField] private string ExitToDesktop;
    */

    public void StartGameButton()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void OptionsButton()
    {
        SceneManager.LoadScene("Settings");
    }

    public void BackToStartGameButton()
    {
        SceneManager.LoadScene("StartGame");
    }

    public void BackToSettingsButton()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void BackToMainMenuButton()
    {
        SceneManager.LoadScene("StartGame");
    }

    public void AudoSettingsButton()
    {
        SceneManager.LoadScene("AudioSettings");
    }

    public void AreYouSureNo()
    {
        SceneManager.LoadScene("StartGame");

    }

    public void AreYouSureYes()
    {
        Application.Quit();
    }


    public void AreYouSure()
    {
        SceneManager.LoadScene("AreYouSure");
    }


    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }


    public void ExitButton()
    {
        SceneManager.LoadScene("ExitToDesktop");
    }
}
