using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool isGameOver;
    public int maxAmountOfFrames;
    public BallSpawner spawner;
    public PitController pitController;
    public ScoreManager scoreManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void EndGame()
    {
        scoreManager.totalScore += scoreManager.currentFrameScore;
        scoreManager.currentFrameScore = 0;
        isGameOver = true;
    }
    public void StartNewThrow()
    {
        if (scoreManager.currentFrame >= maxAmountOfFrames)
        {
            // FINISH GAME
            EndGame();
            
        }
        else
        {
            spawner.RestartGame();
        }
    }

    public void GoToNextFrame()
    {
        scoreManager.currentFrame++;

        if (scoreManager.currentFrame >= maxAmountOfFrames) //CHECKING IF ITS THE LAST FRAME
        {
            // FINISH GAME
            EndGame();
            //DOING NOTHING
        }
        else
        {
            scoreManager.totalScore += scoreManager.currentFrameScore;
            scoreManager.currentFrameScore = 0;
            //set score
            //reset all pins
            pitController.ResetAllPins();
            //Reset throws
            spawner.ResetThrows();
        }



    }
}
