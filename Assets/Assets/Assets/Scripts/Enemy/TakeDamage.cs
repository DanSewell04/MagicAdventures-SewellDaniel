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

        
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            OnDestroy();
            audioSource = gameObject.AddComponent<AudioSource>();
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
        // Check if the audio clip is assigned and the AudioSource exists
        if (deathSound != null && audioSource != null)
        {
            audioSource.PlayOneShot(deathSound);
        }
    }
}
