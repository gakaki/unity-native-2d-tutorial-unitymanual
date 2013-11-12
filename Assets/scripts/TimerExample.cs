using UnityEngine;
using System.Collections;

public class TimerExample : MonoBehaviour {

	void Start()
	{
		//Log "Hello!" 5 times with 1 second between each log
//		StartCoroutine(RepeatMessage(5, 1.0f,"Hello!"));

		StartCoroutine(SaySomeThings());


	}
	//Say some messages separated by time
	IEnumerator SaySomeThings()
	{
		Debug.Log("The routine has started");
		yield return StartCoroutine(Wait(1.0f));
		Debug.Log("1 second has passed since the last message");
		yield return StartCoroutine(Wait(2.5f));
		Debug.Log("2.5 seconds have passed since the last message");
	}
	IEnumerator Wait(float duration)
	{
		for(float timer = 0; timer < duration; timer += Time.deltaTime)
			yield return 0;
	}

	IEnumerator RepeatMessage(int count,float frequency,string message)
	{
		for(int i = 0; i < count; i++)
		{
			Debug.Log(message);
			for(float timer = 0; timer < frequency; timer += Time.deltaTime)
				yield return 0;
			
		}
	}
}
