using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{
    public Rigidbody rigidbodyPin;

    Vector3 originalPosition;
    Quaternion originalRotation;

    // Start is called before the first frame update
    void Start()
    {
        originalPosition = rigidbodyPin.position;
        originalRotation = rigidbodyPin.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ResetPin()
    {
        gameObject.SetActive(true);

        rigidbodyPin.velocity = Vector3.zero;
        rigidbodyPin.angularVelocity = Vector3.zero;

        //Go back to original position
        rigidbodyPin.MovePosition(originalPosition);

        //go back to original rotation
        rigidbodyPin.MoveRotation(originalRotation);
    }

    public bool IsItFallen()
    {
        bool isFallen = false;
        if (transform.rotation.x > 0.1f || transform.rotation.x < -0.1f
            || transform.rotation.z > 0.1f || transform.rotation.z < -0.1f)
        {
            isFallen = true;
        }

        return isFallen;

    }
}
