using UnityEngine;
using System.Collections;

public class AddForce2 : MonoBehaviour {
	public float x_power = 0.0f;
	public float y_power = 100.0f;
	void FixedUpdate () {
		if( Input.GetMouseButtonDown(0)){
			Vector2 x_force = new Vector2(x_power,y_power);
			rigidbody2D.AddForce(x_force);
			Debug.Log("is called add force 2");
		}
	}
}
