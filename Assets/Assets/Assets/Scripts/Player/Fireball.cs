using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    public GameObject fireballPrefab; // Prefab for the fireball
    public float fireballSpeed = 10f; // Speed of the fireball
    public AudioClip fireSound; // Sound for firing the fireball

    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ShootFireball();
        }
    }

    void ShootFireball()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, Camera.main.transform.position.z));

        GameObject fireball = Instantiate(fireballPrefab, transform.position, Quaternion.identity);
        Rigidbody2D rb = fireball.GetComponent<Rigidbody2D>();

        if (rb != null)
        {
            Vector2 direction = (mousePos - transform.position).normalized;
            rb.velocity = direction * fireballSpeed;

            // Play fire sound effect
            if (audioSource != null && fireSound != null)
            {
                audioSource.PlayOneShot(fireSound);
            }
        }
    }
}
