using UnityEngine;
using System.Collections;

[AddComponentMenu("SSFS/Input Transform")]

public class InputTransform : MonoBehaviour
{
	[System.Serializable]
	public class Keys
	{
		public KeyCode forward = KeyCode.W;
		public KeyCode backward = KeyCode.S;
		public KeyCode left = KeyCode.A;
		public KeyCode right = KeyCode.D;
		public KeyCode up = KeyCode.Space;
		public KeyCode down = KeyCode.LeftControl;
		public KeyCode boost = KeyCode.LeftShift;

		public Keys ()
		{
			forward = KeyCode.W;
			backward = KeyCode.S;
			left = KeyCode.A;
			right = KeyCode.D;
			up = KeyCode.Space;
			down = KeyCode.LeftControl;
			boost = KeyCode.LeftShift;
		}
	}
	public Keys keys = new Keys();
	public Space transformSpace = Space.Self;
	public float speed = 5f,boostSpeed = 10f;
	float cspd = 0f;
	Vector3 movement = Vector3.zero;

	void Update ()
	{
		float spd = (Input.GetKey(keys.boost))?boostSpeed:speed;

		Vector3 newMovement = Vector3.zero;

		if (Input.GetKey(keys.forward)) newMovement += Vector3.forward;
		if (Input.GetKey(keys.backward)) newMovement += -Vector3.forward;
		if (Input.GetKey(keys.right)) newMovement += Vector3.right;
		if (Input.GetKey(keys.left)) newMovement += -Vector3.right;
		if (Input.GetKey(keys.up)) newMovement += Vector3.up;
		if (Input.GetKey(keys.down)) newMovement += -Vector3.up;

		newMovement = newMovement.normalized;

		cspd = Mathf.Lerp(cspd,(newMovement.magnitude > 0f) ? spd : 0f,Time.deltaTime);
		movement = Vector3.Lerp(movement, newMovement,Time.deltaTime);

		transform.Translate(movement * cspd * Time.deltaTime, transformSpace);
	}
}