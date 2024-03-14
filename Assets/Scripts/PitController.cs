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

        foreach(Pin pin in pins)
        {
            if(pin.IsItFallen())
            {
                pin.gameObject.SetActive(false);
                amountOfHits++;
                Debug.Log(pin.gameObject.name + " is fallen");
            }
        }
        manager.scoreManager.currentFrameScore = amountOfHits;
        if(amountOfHits == 10)
        {
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

