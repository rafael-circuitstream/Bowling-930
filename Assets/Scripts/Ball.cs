using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody ballRb;

    private float moveSpeed = 20f;

    private Vector3 ballMoveDirection = new Vector3(3f, 0f, 3f);
    private Vector3 ballStartPos = new Vector3(0f, 0f, -20f);

    private float horizontal;

    // Start is called before the first frame update
    void Start()
    {
        ballRb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        #region

        // transform refers to the Transform component of this game object
        // Transform which refers to the Transform class

        //ballRb.velocity = Vector3.forward; // moving the rigidbody

        // if ball has reached the end of the lane, return to the beginning
        //if (transform.position.z > 20f) // >, <, >=, <=, ==, !=, !       || (or) , && (and)
        //{
        //    transform.position = ballStartPos;
        //}
        //else
        //{
        //    transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed); // moving the transform 
        //}
        #endregion // lecture

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // BOWL
            ballRb.velocity = Vector3.forward * moveSpeed;
        }

        horizontal = Input.GetAxisRaw("Horizontal");

        if (horizontal > 0)
        {
            // move the ball to the right
            transform.Translate(Vector3.right * Time.deltaTime);
        } else if (horizontal < 0)
        {
            // move ball to the left
            transform.Translate(-Vector3.right * Time.deltaTime);
        }
    }
}
