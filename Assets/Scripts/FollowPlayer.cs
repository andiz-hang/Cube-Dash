using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public Transform player;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        Vector3 positionUpdate = player.position;
        transform.position = player.position + offset;

        if (positionUpdate.x > 12 || positionUpdate.x < -12 || positionUpdate.y < -2) { // If the player falls off the stage, the camera stops following
            FindObjectOfType<GameManager>().GameOver();
            this.enabled = false;
        }
    }
}
