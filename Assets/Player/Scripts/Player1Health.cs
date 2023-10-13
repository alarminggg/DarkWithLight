using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Health : MonoBehaviour
{

    [SerializeField] float maxHitPoints = 100f;
    float hitPoints;
    
    private bool dead = false;

    NewPlayer1Movement newPlayer1Movement;

    

    public bool IsDead
    {
        get
        {
            return dead;
        }
        set
        {
            dead = value;
            newPlayer1Movement.isDead = dead;
        }
    }

    void Start()
    {
        hitPoints = maxHitPoints;

        newPlayer1Movement = GetComponent<NewPlayer1Movement>();
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

    public void Touch(float rawHeal)
    {
        hitPoints += rawHeal;

        Debug.Log("HEALING! " + hitPoints.ToString());
    }

    float NormalisedHitPoint()
    {
        return hitPoints / maxHitPoints;
    }


    void OnDeath()
    {
        Debug.Log("GAME OVER - YOU DIED");
        GetComponent<NewPlayer1Movement>().enabled = false;
        IsDead = true;
    }



}