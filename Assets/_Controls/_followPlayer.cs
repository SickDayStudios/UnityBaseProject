using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _followPlayer : MonoBehaviour {

	public Transform player;

	public Vector3 offset;

	
	void Update () {
		transform.position = player.transform.position + offset;
	}
}