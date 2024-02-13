using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private int lifes = 5;

    private bool isGameOver;

    private UIManager uiManager;

    void Start()
    {

    }


    void Update()
    {
        GameOver();
    }

    private void GameOver()
    {
        if (lifes == 0)
        {
            isGameOver = true;
            uiManager.ShowGameOverPanel();
        }

    }
}
