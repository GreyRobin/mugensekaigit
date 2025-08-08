using UnityEngine;

public class cameracontroller : MonoBehaviour
{
	[SerializeField] Transform followTarget;

	[SerializeField] float distance = 5;

	float rotationY;

	private void Update()
	{
		//rotationY += Input.GetAxis("Mouse X");

		var targetRotation = Quaternion.Euler(0, rotationY, 0);

		transform.position = followTarget.position - Quaternion.Euler(0, 0, 0) * new Vector3(0, 0, distance);
		//transform.position = targetRotation;
	}
}
