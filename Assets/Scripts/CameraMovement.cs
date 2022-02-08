using UnityEngine;

public class CameraMovement : MonoBehaviour {

    public Transform player;
    public Vector3 offset;
    public static bool rotateAroundPlayer = true;
    public float rotationSpeed = 5.0f;
	
	void LateUpdate () {
        if (rotateAroundPlayer) {
            Quaternion camTurnAngle = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * rotationSpeed, Vector3.up);
            offset = camTurnAngle * offset;
        }
        transform.position = player.position + offset;
        if (rotateAroundPlayer)
        {
            transform.LookAt(player);
        }
	}
}