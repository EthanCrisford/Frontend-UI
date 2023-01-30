using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGameButton : MonoBehaviour
{
    [SerializeField] private string newGameLevel = "MainMenu";

    public void NewgameButton()
    {
        SceneManager.LoadScene(newGameLevel);
    }
}
