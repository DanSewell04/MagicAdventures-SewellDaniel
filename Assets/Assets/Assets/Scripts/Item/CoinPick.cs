using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPick : MonoBehaviour
{
    public CoinCounterManager coinCounterManager;

    private AudioSource audioSource; // Reference to the AudioSource component

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            // If AudioSource is not attached, add it
            audioSource = gameObject.AddComponent<AudioSource>();
        }
        // Ensure the AudioSource initially starts disabled
        audioSource.playOnAwake = false;
        audioSource.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Play the coin pickup sound if an AudioClip is assigned
            if (audioSource != null && audioSource.clip != null)
            {
                // Enable the AudioSource, play the sound, then disable it again
                audioSource.enabled = true;
                audioSource.PlayOneShot(audioSource.clip);
                audioSource.enabled = false;
            }

            coinCounterManager.coinpickup();
            Destroy(gameObject);
        }
    }
}

