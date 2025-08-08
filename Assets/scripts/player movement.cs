using UnityEngine;
using UnityEngine.InputSystem;

public class playermovement : MonoBehaviour
{
	public Rigidbody rb;
	public float moveSpeed;
	private Vector2 moveInput;
	public InputActionReference move;

	private void Update()
	{
		moveInput = move.action.ReadValue<Vector2>();
	}

	private void FixedUpdate()
	{
		Vector3 moveDirection = new Vector3(moveInput.x, 0, moveInput.y).normalized;
		rb.linearVelocity = moveDirection * moveSpeed + new Vector3(0, rb.linearVelocity.y, 0);
	}
}
