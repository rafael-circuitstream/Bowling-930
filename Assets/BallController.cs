using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float _forceSpeed;
    public float maxDistanceFromOrigin;
    public GameObject arrow;

    private Rigidbody ballRb;
    private Animator arrowAnimator;

    private float _originalX;
    private float moveSpeed = 3f;

    private Vector3 ballMoveDirection = new Vector3(3f, 0f, 3f);
    private Vector3 ballStartPos = new Vector3(0f, 0f, -5f);

    private float horizontal;

    bool isBallThrown;

    // Start is called before the first frame update
    void Start()
    {
        ballRb = GetComponent<Rigidbody>();
        arrow = transform.GetChild(1).gameObject;
        arrowAnimator = arrow.GetComponent<Animator>();

        _originalX = transform.position.x;
        isBallThrown = false;
        // transform refers to the Transform component of this game object
        // Transform which refers to the Transform class
    }

    // Update is called once per frame
    void Update()
    {

        if(!isBallThrown)
        {
            //WHEN THE BALL HASN'T BEEN THROWN
            //arrow.transform.position = transform.position;

            if (Input.GetKeyDown(KeyCode.Space))
            {
                //Bowl
                ballRb.AddForce(arrow.transform.forward * _forceSpeed, ForceMode.Impulse);
                isBallThrown = true;
                arrowAnimator.SetBool("CannotThrow", true);
                arrow.gameObject.SetActive(false);
            }

            horizontal = Input.GetAxisRaw("Horizontal");

            if (horizontal > 0)
            {
                // move the ball to the right
                if (transform.position.x < maxDistanceFromOrigin + _originalX)
                    transform.Translate(Vector3.right * Time.deltaTime);
            }
            else if (horizontal < 0)
            {
                // move the ball to the left
                if (transform.position.x > _originalX - maxDistanceFromOrigin)
                    transform.Translate(-Vector3.right * Time.deltaTime);
            }
        }
        
    }
}