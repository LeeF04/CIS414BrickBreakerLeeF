// Written by Lee Fischer
// 2/9/25

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundManager : MonoBehaviour
{
    // Variables
    [SerializeField] protected List<BreakBrick> bricks;
    [SerializeField] protected GameObject canvasScene;

    // Methods
    private void Update()
    {
        EndRound();
    }

    private void Awake()
    {
        GameObject[] gOs = GameObject.FindObjectsOfType<GameObject>();

        if(gOs.Length > 1)
        {
            Destroy(gameObject);
        }
    }


    protected void EndRound()
    {
        if (FindObjectsOfType<BreakBrick>().Length <= 0)
        {
            canvasScene.SetActive(true);
        }
    }

    // Accessors
}
