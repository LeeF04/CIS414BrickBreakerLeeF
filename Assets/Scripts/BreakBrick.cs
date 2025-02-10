// Written by Lee Fischer
// 2/9/25

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakBrick : MonoBehaviour
{
    // Variables
    [SerializeField, Range(1,20)]protected int hitPoints;
    protected int currentHitPoints = 0;

    // Methods
    private void Awake()
    {
        currentHitPoints = hitPoints;
    }
    public void Break(int aDamage)
    {
        currentHitPoints -= aDamage;

        DestroyBrick();
    }

    protected void DestroyBrick()
    {
        if (currentHitPoints < 0)
        {
            // Can Add Animations Here
            //FindObjectOfType<RoundManager>().RemoveBrick(this);
            Destroy(gameObject);
        }
    }

    // Accessors
}
