using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayers : MonoBehaviour
{
    [SerializeField]
    float rawDamage = 1000f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player2")
        {
            Debug.Log("Player 2 burned in the light!");
            Player1Health player1Health = collision.gameObject.GetComponent<Player1Health>();
            if (player1Health != null)
            {
                player1Health.Hit(rawDamage);
            }
        }
    }
}
