using UnityEngine;

public class BallController : MonoBehaviour
{
    //public float initialDelay; // Initial delay before the ball starts moving
    public float speed; // Speed of the ball

    private Rigidbody rb;
    private Vector3 initialDirection = Vector3.forward; // Initial direction towards the bricks

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        // Start the ball movement after the initial delay
    }

    void FixedUpdate()
    {
        // Ensure the ball's movement is constrained to the x and z axes
        Vector3 constrainedVelocity = new Vector3(rb.velocity.x, 0, rb.velocity.z).normalized * speed;
        rb.velocity = constrainedVelocity;
    }

    public void getTheBallGoing()
    {
        Invoke("StartMovement", 1f);
    }

    void StartMovement()
    {
        rb.velocity = initialDirection.normalized * speed;
    }

    void OnCollisionEnter(Collision collision)
    {
        Vector3 reflectDir = Vector3.Reflect(rb.velocity, collision.contacts[0].normal);
        rb.velocity = new Vector3(reflectDir.x, 0, reflectDir.z).normalized * speed;

        if (collision.gameObject.CompareTag("Brick"))
        {
            Destroy(collision.gameObject);
        }
    }
}
