// Written by Lee Fischer
// 2/10/25

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreDisplay : MonoBehaviour
{
    // Variables
    [SerializeField] protected TMP_Text scoreText;
    [SerializeField] protected string preText = "Score: ";
    [SerializeField] protected string postText = " pts";

    // Methods
    public void Start()
    {
        ChangeScore();
    }
    public void ChangeScore()
    {
        scoreText.text = preText + GameManager.Instance.PlayerScore + postText;
    }

    // Accessors
}
