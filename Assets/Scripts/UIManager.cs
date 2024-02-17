using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private GameObject winPanel;
    [SerializeField] private TextMeshProUGUI lifeText;

    private GameManager gameManagerScript;

    void Start()
    {
        gameManagerScript = FindObjectOfType<GameManager>();
    }


    public void UpdateLifesText(int lifes)
    {
        lifeText.text = "Lifes: " + lifes;
    }

    public void ShowGameOverPanel()
    {
        gameOverPanel.SetActive(true);
    }

    public void HideGameOverPanel()
    {
        gameOverPanel.SetActive(false);
    }

}
