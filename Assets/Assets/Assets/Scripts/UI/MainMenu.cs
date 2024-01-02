using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("Level"); // Load the game scene
    }

    public void Back()
    {
        SceneManager.LoadScene("MainMenu"); //returns to the menu
    }


    public void Exit()
    {
        Application.Quit(); // Quit the application
    }

    public void GameOver()
    {
        SceneManager.LoadScene("GameOver"); // GameOver Scene is prompted.
    }

    public void GameCompleted()
    {
        SceneManager.LoadScene("GameCompleted"); // Game becomes complete meaning that the player can return to the home screen or play again.
    }
}

