using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    

    //private bool isGameOver;

    private UIManager uiManager;
    private Movement movementScript;

    void Start()
    {
        uiManager = FindObjectOfType<UIManager>();

        movementScript = FindObjectOfType<Movement>();

        uiManager.HideGameOverPanel();
        uiManager.HideWinPanel();
    }


    void Update()
    {
    }

    public void RestartGameScene()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }


}
