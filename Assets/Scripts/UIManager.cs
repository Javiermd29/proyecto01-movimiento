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
    [SerializeField] private TextMeshProUGUI timesDied;
    [SerializeField] private Button restartButton;

    private GameManager gameManagerScript;

    void Start()
    {
        gameManagerScript = FindObjectOfType<GameManager>();
        lifeText.text = "Lifes: 5";

        restartButton.onClick.AddListener(() => { gameManagerScript.RestartGameScene(); });

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

    public void ShowWinPanel(int lifes)
    {

        timesDied.text = "Times Died: " + (5 - lifes);
        winPanel.SetActive(true);

    }

    public void HideWinPanel()
    {
        gameOverPanel.SetActive(false);
    }

}
