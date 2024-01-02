using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorController : MonoBehaviour
{
    public int requiredCoins = 8; // Number of coins required to unlock the door.
    public CoinCounterManager coinManager;

    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        bool canopendoor = coinManager.coinCollected;
        if (other.CompareTag("Player")&& canopendoor)
        {
            SceneManager.LoadScene("GameCompleted");
        }
    }
}

