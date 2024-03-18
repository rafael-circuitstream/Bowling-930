using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIManager : MonoBehaviour
{
    public UIFrame[] frames;

    public Image strikeNotification;
    public Image spareNotification;

    public UIResults results;
    // Start is called before the first frame update
    void Start()
    {
        //set frame number for each frame in array
        for(int i = 0; i < frames.Length; i++)
        {
            frames[i].SetFrameNumber(i + 1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowStrikeImage()
    {
        strikeNotification.gameObject.SetActive(true);
        Invoke("HideImages", 2f);
    }

    public void ShowSpareImage()
    {
        spareNotification.gameObject.SetActive(true);
        Invoke("HideImages", 2f);
    }

    public void HideImages()
    {
        spareNotification.gameObject.SetActive(false);
        strikeNotification.gameObject.SetActive(false);
    }

    public void SetScoreCurrentFrame(int pinsFallen, int throwNumber, int frameIndex)
    {
        frames[frameIndex].SetScore(pinsFallen, throwNumber);
    }
    public void SetTotalScoreOnFrame(int totalScore, int frameIndex)
    {
        frames[frameIndex].SetTotalScore(totalScore);
    }
}
