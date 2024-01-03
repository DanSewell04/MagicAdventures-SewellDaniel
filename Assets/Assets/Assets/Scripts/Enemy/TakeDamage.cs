using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDamage : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject player;
    public int damage;
    public float timeTakenForHit;
    public AudioClip deathSound; // Assign the death sound in the Inspector
    private AudioSource audioSource;

    void Start()
    {
        GameObject getPlayer = GameObject.FindWithTag("Player");
        if (getPlayer != null)
        {
            player = getPlayer;
        }

        // Initialize the AudioSource component
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            // If AudioSource is not attached, add it
            audioSource = gameObject.AddComponent<AudioSource>();
            audioSource.playOnAwake = false; // Ensure it doesn't play on awake
            audioSource.enabled = false; // Disable the AudioSource initially
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<HealthManager>().TakeDamage(damage);
            Debug.Log("Hit!");
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Work");
            float timeRemaining = timeTakenForHit;
            while (timeRemaining > 0) { timeRemaining -= Time.deltaTime; }
            if (timeRemaining <= 0)
            {
                collision.gameObject.GetComponent<HealthManager>().TakeDamage(damage);
            }
        }
    }

    private void OnDestroy()
    {
        if (deathSound != null && audioSource != null)
        {
            // Ensure AudioSource is enabled before playing the sound
            if (!audioSource.enabled)
            {
                audioSource.enabled = true;
                audioSource.PlayOneShot(deathSound);
                audioSource.enabled = false; // Disable it again after playing the sound
            }
            else
            {
                audioSource.PlayOneShot(deathSound);
            }
        }
    }
}
