using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIResults : MonoBehaviour
{
    public TextMeshProUGUI totalScoreText;
    GameManager gameManager;
    
    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        gameObject.SetActive(false);
    }

    public void ShowScore()
    {
        totalScoreText.text = "TOTAL SCORE: " + gameManager.scoreManager.totalScore;
    }
}
