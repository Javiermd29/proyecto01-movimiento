using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    

    private bool isGameOver;
    private int lifes = 5;

    private UIManager uiManager;
    private Movement movementScript;

    void Start()
    {
        uiManager = FindObjectOfType<UIManager>();

        movementScript = FindObjectOfType<Movement>();

        uiManager.HideGameOverPanel();
    }


    void Update()
    {
    }

    public void UpdateLifes(int newLifes)
    {

        lifes += newLifes;
        uiManager.UpdateLifesText(lifes);

        if (lifes == 0)
        {
            isGameOver = true;
            uiManager.ShowGameOverPanel();
        }

    }
}
