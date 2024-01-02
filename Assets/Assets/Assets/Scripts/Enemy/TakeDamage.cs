using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDamage : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject player;
    public int damage;
    public float timeTakenForHit;
    void Start()
    {
        GameObject getPlayer = GameObject.FindWithTag("Player");
        if (getPlayer != null)
        {
            player = getPlayer;
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
            while (timeRemaining > 0) {timeRemaining -= Time.deltaTime;}
            if (timeRemaining <= 0) 
            {
                collision.gameObject.GetComponent<HealthManager>().TakeDamage(damage);
            }
            
            
        }
    }
}
