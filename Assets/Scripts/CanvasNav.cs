// Written by Lee Fischer
// 1/22/25

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasNav : MonoBehaviour
{
    // Variables
    
    
    // Methods
    public void LoadNextScene()
    {
        GameManager.Instance.NextScene();
    }

    public void LoadStartScreen()
    {
        //GameManager.Instance.ResetScore();
        GameManager.Instance.StartScene();
    }
    
    // Accessors
}
