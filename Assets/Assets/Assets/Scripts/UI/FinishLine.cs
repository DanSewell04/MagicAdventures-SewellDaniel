using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            CompleteGame();
        }
    }

    private void CompleteGame()
    {
        
        Debug.Log("Congratulations! You completed the game!");

        SceneManager.LoadScene("GameCompleted");
    }
}
