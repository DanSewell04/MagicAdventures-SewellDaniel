using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CoinManager : MonoBehaviour
{
    public TextMeshProUGUI CoinDisplay;
    public int coinCount;
    public bool coinCollected;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CoinDisplay.text = coinCount.ToString();
        if (coinCount < 7 )
        {
            coinCollected = false;
        }
        else
        {
            coinCollected = true;
        }
    }

    public void coinpickup()
    {
        coinCount++;
    }

    
}
