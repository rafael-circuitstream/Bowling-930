using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public int amountOfThrowns;
    public GameObject[] _ballPrefabs;
    public Vector3 startPosition;


    GameManager manager;

    // Start is called before the first frame update
    void Start()
    {
        manager = FindObjectOfType<GameManager>();
        RestartGame();
    }
    public void ResetThrows()
    {
        amountOfThrowns = 0;
    }
    public void RestartGame()
    {
        if (amountOfThrowns >= 2)
        {
            manager.GoToNextFrame();
        }

        if(!manager.isGameOver)
        {
            amountOfThrowns++;
            GameObject clone = Instantiate(_ballPrefabs[Random.Range(0, _ballPrefabs.Length)], startPosition, Quaternion.identity);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
