using UnityEngine;
using System.Collections;
	
[AddComponentMenu("SSFS/Smoothed Mouse Look")]

public class SmoothMouseLook : MonoBehaviour
{
	
	public enum Axises {X, Y, XandY};
	public Axises axis = Axises.XandY;
	public float xSensitivity = 5.0f;
	public float ySensitivity = 4.0f;
	public float zSway = 5.0f;
	public bool useWalk = false;
	private float jjj = 0.0f;
	public float walkSpeed = 1.0f;
	public float walkTilt = 5.0f;
	public bool canSprint;
	private float xCurrent;
	private float yCurrent;
	private float zCurrent;
	private float xWant;
	private float yWant;
	private float zWant;
	public float smoothing = 1.0f;
	public float minX = 0.0f;
	public float maxX = 360.0f;
	public float minY = -80.0f;
	public float maxY = 80.0f;
	public float minZ = -80.0f;
	public float maxZ = 80.0f;
	public float leanTilt = 15.0f;
	
	public bool lockMouse = true,dependOnCursorLock = true;
	private bool lockingMouse = false;
	
	public bool useLean = false;
	
	void Start ()
	{
		xCurrent = transform.localEulerAngles.x;
		yCurrent = transform.localEulerAngles.y;
		zCurrent = transform.localEulerAngles.z;
		xWant = xCurrent;
		yWant = yCurrent;
		zWant = zCurrent;
	}

	void Update ()
	{
		MouseLock();

		Vector2 inputs = new Vector2 (Input.GetAxis("Mouse X"),Input.GetAxis("Mouse Y"));

		if (dependOnCursorLock && Cursor.lockState == CursorLockMode.None)
			inputs = Vector2.zero;

		if (axis == Axises.X || axis == Axises.XandY)
		{
			yWant+= (inputs.x*xSensitivity);
			//yWant = Mathf.Clamp (yWant,minX,maxX);
			yCurrent =  Mathf.Lerp(yCurrent,yWant,Time.deltaTime/smoothing);
		}
	
		if (axis == Axises.Y || axis == Axises.XandY)
		{
			xWant+= (inputs.y*ySensitivity);
			xWant = Mathf.Clamp (xWant,minY,maxY);
			xCurrent=  Mathf.Lerp(xCurrent,xWant,Time.deltaTime/smoothing);
		}
			
		if (Input.GetKey(KeyCode.Q) && useLean)
			zWant+= 2;
		if (Input.GetKey(KeyCode.E) && useLean)
			zWant-= 2;

		zWant = Mathf.Lerp(zWant,inputs.x*zSway,0.1f);
		zWant = Mathf.Clamp (zWant,minZ,maxZ);
		zCurrent=  Mathf.Lerp(zCurrent,zWant,Time.deltaTime/smoothing);

		if (yWant > 360.0f)
		{
			yWant -= 360.0f;
			yCurrent -= 360.0f;
		}
		
		if (yWant < 0.0f)
		{
			yWant += 360.0f;
			yCurrent += 360.0f;
		}

		if (axis == Axises.X)
		{
			transform.localEulerAngles = new Vector3(transform.localEulerAngles.x,yCurrent,transform.localEulerAngles.z);
		}
		if (axis == Axises.Y)
		{
			transform.localEulerAngles = new Vector3(-xCurrent,transform.localEulerAngles.y,transform.localEulerAngles.z);
		}
		if (axis == Axises.XandY)
		{
			transform.localEulerAngles = new Vector3(-xCurrent,yCurrent,zCurrent);
		}
			
		transform.localEulerAngles = new Vector3(transform.localEulerAngles.x,transform.localEulerAngles.y,zCurrent);

		if (Input.GetKey(KeyCode.W) && useWalk)
		{
			AddWalk();
		}
		if (Input.GetKeyUp(KeyCode.W))
		{
			jjj = 0.0f;
		}
		

	}

	void MouseLock()
	{
		Cursor.visible = (Cursor.lockState == CursorLockMode.None);
		if (lockMouse)
		{
			if (Cursor.lockState == CursorLockMode.None && lockingMouse)
			{
				Cursor.lockState = CursorLockMode.Locked;
			}
			if (Input.GetKeyDown(KeyCode.Escape))
			{
				lockingMouse = false;
			}
			if (Input.GetButtonDown("Fire1"))
			{
				lockingMouse = true;
			}
		}
	}

	void AddWalk ()
	{
		if (canSprint)
		{
			if (!Input.GetKey(KeyCode.LeftShift))
				jjj += walkSpeed*Time.deltaTime;
			else
				jjj += walkSpeed*Time.deltaTime*2f;
		}
		else
		{
			jjj += walkSpeed*Time.deltaTime;
		}
		
		zWant += Mathf.Sin(jjj)*walkTilt/10.0f;
	}
}
