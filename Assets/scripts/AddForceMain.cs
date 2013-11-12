using UnityEngine;
using System.Collections;

public class AddForceMain : MonoBehaviour {
	public float x_power = 0.0f;
	public float y_power = 100.0f;
	Vector2 x_force;	

	void Start () {
		
	}

	void Update () {
		
	}
	
	void FixedUpdate () {
		if( Input.GetMouseButtonDown(0)){
			Force x_force = new Force(x_power,y_power);
			rigidbody2D.AddForce(x_force.Do());
		}
	}

}
