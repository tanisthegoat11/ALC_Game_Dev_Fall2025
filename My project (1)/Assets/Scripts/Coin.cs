using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Coin : MonoBehaviour

{
    public int scoreToGive;
    private void OnTriggerEnter2D (Collider2D collision)
    {
        collision.GetComponent<PlayerController>().AddScore(scoreToGive);
        Destroy(gameObject);
    }
}
