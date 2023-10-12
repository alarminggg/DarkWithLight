using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Health : MonoBehaviour
{

    [SerializeField] float maxHitPoints = 100f;
    float hitPoints;
    private bool dead;

    public bool IsDead
    {
        get { return dead; }
    }

    void Start()
    {
        hitPoints = maxHitPoints;
    }

    public void Hit(float rawDamage)
    {
        hitPoints -= rawDamage;

        Debug.Log("OUCH: " + hitPoints.ToString());

        if (hitPoints <= 0)
        {
            OnDeath();
        }
    }

    float NormalisedHitPoint()
    {
        return hitPoints / maxHitPoints;
    }

    void OnDeath()
    {
        Debug.Log("GAME OVER - YOU DIED");
        GetComponent<NewPlayer1Movement>().enabled = false;
        dead = true;


    }



}