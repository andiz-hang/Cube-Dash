using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{

    public PlayerMovement movement;

    public FollowPlayer cameraFollow;

    void OnCollisionEnter(Collision collisionInfo) {
        if (collisionInfo.collider.tag == "Obstacle") {
            FindObjectOfType<GameManager>().GameOver();
            cameraFollow.enabled = false;
            movement.enabled = false;
        }
    }
}
