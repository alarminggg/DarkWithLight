using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallDamage : MonoBehaviour
{
    [SerializeField]
    float rawDamage = 1000f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player1")
        {
            Debug.Log("Player 1 touched the wall!");
            Player1Health player1Health = collision.gameObject.GetComponent<Player1Health>();
            if (player1Health != null)
            {
                player1Health.Hit(rawDamage);
            }
        }
        if (collision.gameObject.name == "Player2")
        {
            Debug.Log("Player 2 touched the wall!");
            Player2Health player2Health = collision.gameObject.GetComponent<Player2Health>();
            if (player2Health != null)
            {
                player2Health.Hit(rawDamage);
            }
        }
    }
}
