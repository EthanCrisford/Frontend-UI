using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    [SerializeField] private string StartgameButton;
    [SerializeField] private string SettingsButton;
    [SerializeField] private string QuitGameButton;
    [SerializeField] private string BackButton;
    [SerializeField] private string AudioOptionsButton;


    public void StartGameButton()
    {
        SceneManager.LoadScene(StartgameButton);
    }

    public void OptionsButton()
    {
        SceneManager.LoadScene(SettingsButton);
    }

    public void QuitButton()
    {
        SceneManager.LoadScene(QuitGameButton);
    }

    public void BackToButton()
    {
        SceneManager.LoadScene(BackButton);
    }

    public void AudoSettingsButton()
    {
        SceneManager.LoadScene(AudioOptionsButton);
    }
}
