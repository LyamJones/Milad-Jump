using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	public Transform target;

	//Move camera after player movement
	void LateUpdate () {
		if (target.position.y > transform.position.y)
		{
			Vector3 newPos = new Vector3(transform.position.x, target.position.y, transform.position.z);
			transform.position = newPos;
		}
	}
}
