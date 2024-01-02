using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CoinPickup : MonoBehaviour
{
    public CoinManager coinManager;

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "Player")
        {
            coinManager.coinpickup();
            Destroy(gameObject);
        }
    }
}
