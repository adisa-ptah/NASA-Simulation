using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PrefabSwapper : MonoBehaviour
{
	public List<GameObject> prefabs = new List<GameObject>();
	public CameraOrbit camOrbitter = null;
	int i = 0;
	GameObject obj;

	void Start ()
	{
		SwapPrefab();
	}

	void Update ()
	{
		if ( Input.GetKeyDown( KeyCode.D ) ) NextPrefab();
		if ( Input.GetKeyDown( KeyCode.A ) ) LastPrefab();
	}

	void NextPrefab ()
	{
		i = ( int )Mathf.Repeat( i + 1 , prefabs.Count );
		SwapPrefab();
	}

	void LastPrefab ()
	{
		i = ( int )Mathf.Repeat( i - 1 , prefabs.Count );
		SwapPrefab();
    }

	void SwapPrefab ()
	{
		if ( obj != null )
			Destroy( obj );
		obj = Instantiate( prefabs[ i ] , Vector3.zero , Quaternion.identity ) as GameObject;
		if ( camOrbitter != null )
			camOrbitter.target = obj.transform;
	}
}