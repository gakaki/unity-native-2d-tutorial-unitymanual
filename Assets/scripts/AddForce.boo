import UnityEngine

class AddForce (MonoBehaviour): 
	public  x_power = 0.0
	public  y_power = 100.0
	
	def Start ():
		pass
	def Update ():
		if ( Input.GetMouseButtonDown(0)):
			self.rigidbody2D.AddForce(Vector2(self.x_power,self.y_power))
			Debug.Log("debug error type!")

	def FixedUpated ():
		pass
#		if ( Input.GetMouseButtonDown(0)):
#			self.rigidbody2D.AddForce(Vector2(self.x_power,self.y_power))
#			Debug.Log("debug error type!")
		