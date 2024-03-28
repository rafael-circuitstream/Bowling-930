using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTriggerControl : MonoBehaviour
{
    public GameObject closeCamera;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Ball"))
        {
            closeCamera.SetActive(true);
            Invoke("HideCamera", 3f);
        }
        
    }

    public void HideCamera()
    {
        closeCamera.SetActive(false);
    }
}
