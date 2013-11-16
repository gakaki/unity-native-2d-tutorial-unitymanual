using UnityEngine;
using System.Collections;

public class AddForce2 : MonoBehaviour {
	public float x_power = 0.0f;
	public float y_power = 100.0f;
	void FixedUpdate () {
		if( Input.GetMouseButtonDown(0)){
			rigidbody2D.AddForce(new Vector3(x_power,y_power,0.0f));
		}
	}

	void OnCollision2DEnter(Collision2D col)
	{
		Debug.Log(col.gameObject);
		if(col.rigidbody){
			col.rigidbody.AddForce(new Vector2(0.0f,20000.0f));
		}
	}
}
