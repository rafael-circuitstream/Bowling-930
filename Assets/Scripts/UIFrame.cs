using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class UIFrame : MonoBehaviour
{
    public TextMeshProUGUI firstThrowScore;
    public TextMeshProUGUI secondThrowScore;

    public TextMeshProUGUI frameNumberText;
    public TextMeshProUGUI totalScoreText;

    int memoryFirstThrowPins;
    int memorySecondThrowPins;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetFrameNumber(int frameNumber)
    {
        frameNumberText.text = frameNumber.ToString();
    }

    public void SetScore(int pinsFallen, int throwNumber)
    {
        if(throwNumber == 1) //HERE WILL EXECUTE ON THE FIRST THROW
        {
            memoryFirstThrowPins = pinsFallen;
            if (pinsFallen == 10)
            {
                //SHOW X ON THE RIGHT TEXT
                secondThrowScore.text = "X";
            }
            else
            {
                firstThrowScore.text = pinsFallen.ToString();
                //SET TEXT ON LEFT TO BE SCORE
            }
        }
        else if(throwNumber == 2) //HERE WILL EXECUTE ON THE SECOND
        {
            memorySecondThrowPins = pinsFallen;
            if(memorySecondThrowPins + memoryFirstThrowPins == 10) //SPARE = PINSFALLEN ON THE FIRST THROW + PINS FALLEN ON THE SECOND THROW == 10
            {
                secondThrowScore.text = "/"; //if spare, THEN SHOW "/"
            }
            else
            {
                //SET TEXT ON LEFT TO BE SCORE
                secondThrowScore.text = pinsFallen.ToString();
            }
            
            
            
            
        }
    }

    public void SetTotalScore(int totalScore)
    {
        totalScoreText.text = totalScore.ToString();
    }
}
