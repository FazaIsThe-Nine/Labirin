using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public PlayManager getCoin;
    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            getCoin.coinCount++;
        }
    }
}
