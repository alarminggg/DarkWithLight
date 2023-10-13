using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealingLight : MonoBehaviour
{
    [SerializeField]
    float rawHeal = 20f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player1")
        {
            Debug.Log("Player 1 Feel Light!");
            Player1Health player1Health = collision.gameObject.GetComponent<Player1Health>();
            if (player1Health != null)
            {
                player1Health.Touch(rawHeal);
            }
        }
    }
}
