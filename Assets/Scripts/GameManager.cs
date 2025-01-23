// Written by Lee Fischer
// 1/22/25

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Variables
    private static GameManager instance;
    private float playerScore = 0;

    // Methods


    // Accessors
    public static GameManager Instance
    { 
        get 
        {
            if (instance == null)
            {
                GameObject aGO = new GameObject("Game Manager");
                instance = aGO.AddComponent<GameManager>();
                DontDestroyOnLoad(aGO);
            }
            return instance; 
        } 
    }

}
