using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject arrow;
    public GameObject _ballPrefab;
    public Vector3 startPosition;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }
    public void RestartGame()
    {
        GameObject clone = Instantiate(_ballPrefab, startPosition, Quaternion.identity);

        arrow.transform.SetParent(clone.transform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
