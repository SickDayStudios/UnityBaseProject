using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _Jump : MonoBehaviour {

	public float thrust;
	public Rigidbody selfRigidbody;

	// Use this for initialization
	void Start () {
		selfRigidbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("space"))
		selfRigidbody.AddForce(new Vector3(0.0f, thrust, thrust), ForceMode.Impulse);
	}
}
