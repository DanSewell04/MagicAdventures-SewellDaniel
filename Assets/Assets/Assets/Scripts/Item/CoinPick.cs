using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPick : MonoBehaviour
{
    public CoinCounterManager coinCounterManager;

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "Player")
        {
            coinCounterManager.coinpickup();
            Destroy(gameObject);
        }
    }
}

