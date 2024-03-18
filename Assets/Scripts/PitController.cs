using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PitController : MonoBehaviour
{
    public Pin[] pins;
    GameManager manager;
    // Start is called before the first frame update
    void Start()
    {
        manager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter(Collider other)
    {
        
        if(other.gameObject.CompareTag("Ball")) //if(other.gameobject.tag == "Ball")
        {
            
            Destroy(other.gameObject);
            Invoke("CheckPins", 1.5f);
        }
        
    }


    public void CheckPins()
    {
        

        //ITERATING THROUGH EVERY PIN WE HAVE ON OUR ARRAY
        int amountOfHits = 0;
        int currentHits = 0;
        foreach(Pin pin in pins)
        {
            if(pin.IsItFallen())
            {
                if (pin.gameObject.activeInHierarchy) currentHits++;
                pin.gameObject.SetActive(false);
                amountOfHits++;
                Debug.Log(pin.gameObject.name + " is fallen");
            }
        }
        manager.scoreManager.currentFrameScore = amountOfHits;

        manager.uiManager.SetScoreCurrentFrame(currentHits, manager.spawner.amountOfThrowns, manager.scoreManager.currentFrame);



        if(amountOfHits == 10)
        {
            if (manager.spawner.amountOfThrowns == 1)
            {
                //saving the appropriate score the appropriate way
                //STRIKE
                manager.uiManager.ShowStrikeImage();
            }
            else if (manager.spawner.amountOfThrowns == 2)
            {
                //SPARE
                manager.uiManager.ShowSpareImage();
            }

            manager.GoToNextFrame(); 
        }

        manager.StartNewThrow();

        Debug.Log("Amount of points: " + amountOfHits);

    }

    public void ResetAllPins()
    {
        foreach(Pin pin in pins)
        {
            pin.gameObject.SetActive(true);
            pin.ResetPin();
        }
    }

}

