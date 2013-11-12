using UnityEngine;
using System.Collections;

public class Force  {

	public Vector2 x_force;
	public Force( float x_power, float y_power ){

		x_force = new Vector2(x_power,y_power);
	}

	public Vector2 Do(){

		return x_force;
	}

}
