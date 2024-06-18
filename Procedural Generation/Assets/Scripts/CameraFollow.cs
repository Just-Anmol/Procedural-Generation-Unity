using UnityEngine;

public class CameraFollow2D : MonoBehaviour
{
    public Transform player;        // Reference to the player's transform
    public Vector3 offset;          // Offset between the player and the camera
    public float smoothSpeed = 0.125f;  // Smooth speed for camera movement

    void Update()
    {
        // Desired position is the player's position plus the offset
        Vector3 desiredPosition = player.position + offset;

        // Smoothly interpolate between the current position and the desired position
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        // Set the camera's position to the smoothed position, locking the Z axis
        transform.position = new Vector3(smoothedPosition.x, smoothedPosition.y, transform.position.z);
    }
}
