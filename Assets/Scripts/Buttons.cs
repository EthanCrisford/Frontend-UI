using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    [SerializeField] private string newGameLevel = "MainMenu";
    //[SerializeField] private string newGameLevel = "Settings";

    public void StartGameButton()
    {
        SceneManager.LoadScene(newGameLevel);
    }
}
