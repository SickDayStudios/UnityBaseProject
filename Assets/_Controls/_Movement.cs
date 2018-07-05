using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _Movement : MonoBehaviour {
	public Rigidbody selfRigidbody;
	public float verticalForce = 2000f;
	public float horizontalForce = 500f;


	void Update () {

		var forward = Input.GetKey("w");
		var backward = Input.GetKey("s");
		var left = Input.GetKey("a");
		var right = Input.GetKey("d");

		
		if (forward == true) { selfRigidbody.AddForce( 0, 0, verticalForce * Time.deltaTime ); }
		if (backward == true) { selfRigidbody.AddForce( 0, 0, -verticalForce * Time.deltaTime ); }
		if (left == true) { selfRigidbody.AddForce( -verticalForce * Time.deltaTime, 0, 0 ); }
		if (right == true) { selfRigidbody.AddForce( verticalForce * Time.deltaTime, 0, 0 ); }
		
		}
	}