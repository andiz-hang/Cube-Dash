using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public Transform playerPosition;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    private bool rightKeyDown = false;
    private bool leftKeyDown = false;

    // Methods
    // Is called every frame
    void Update()
    {
        // Player moves right
        if ( /* Input.GetKey("d") || */ Input.GetKey(KeyCode.RightArrow) ) {
            rightKeyDown = true;
        } else {
            rightKeyDown = false;
        }

        // player moves left
        if ( /* Input.GetKey("a") || */ Input.GetKey(KeyCode.LeftArrow) ) {
            leftKeyDown = true;
        } else {
            leftKeyDown = false;
        }

        // If the player falls off the stage, stop movement
        if (playerPosition.position.y < 0) {
            this.enabled = false;
        }
    }
    // FixedUpdate for physics changes
    void FixedUpdate()
    {
        // Constantly add a forward force to the player
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if ( rightKeyDown ) {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if ( leftKeyDown ) {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
