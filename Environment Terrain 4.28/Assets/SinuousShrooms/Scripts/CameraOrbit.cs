/*
This script orbits the camera around a specific object, 

Email :: thomas.ir.rasor@gmail.com
*/

using UnityEngine;
using System.Collections;

public class CameraOrbit : MonoBehaviour
{
	public Transform target;
	public Vector3 offset = Vector3.zero;
	public float distance = 2f;
	public float lerpSpeed = 3f;

	public bool raycastedDistance = false;

	Vector3 wrot, crot;
	Vector3 worigin, corigin;

	void Update ()
	{
		float t = Time.deltaTime * 2f * lerpSpeed;

		if ( Input.GetMouseButton( 1 ) )
			Camera.main.fieldOfView = 35f;
		else
			Camera.main.fieldOfView = 50f;

		if ( Input.GetMouseButton( 0 ) )
		{
			wrot.y += Input.GetAxis( "Mouse X" ) * 3f;
			wrot.x -= Input.GetAxis( "Mouse Y" ) * 3f;
		}
		wrot.z = 0f;

		crot.x = Mathf.LerpAngle( crot.x , wrot.x , t );
		crot.y = Mathf.LerpAngle( crot.y , wrot.y , t );
		crot.z = Mathf.LerpAngle( crot.z , wrot.z , t );

		transform.rotation = Quaternion.Euler( crot );

		if ( target != null )
			worigin = target.position + offset;
		else
			worigin = Vector3.zero;

		if ( raycastedDistance )
		{
			RaycastHit h;
			Ray r = new Ray( worigin - transform.forward * ( distance + 1f ) , transform.forward );
			if(Physics.Raycast(r,out h))
			{
				worigin = h.point;
			}
		}

		corigin = Vector3.Lerp( corigin , worigin , t );

        transform.position = corigin - transform.forward * distance;
	}

	void OnDrawGizmosSelected ()
	{
		Gizmos.color = Color.red;
		Gizmos.DrawWireSphere( worigin , 0.2f );
		Gizmos.DrawLine( worigin , transform.position + offset );
		Gizmos.color = Color.blue;
		Gizmos.DrawWireSphere( corigin , 0.2f );
		Gizmos.DrawLine( corigin , transform.position + offset );
	}

}
