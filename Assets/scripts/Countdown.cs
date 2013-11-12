using UnityEngine;
using System.Collections;

public class Countdown : MonoBehaviour {

	public float timer = 3;

	public float firstTimer = 3;
	public float secondTimer = 2;
	public float thirdTimer = 1;
	public int   count_coroutine = 0;

	void Start () {
//		StartCoroutine(countdown());
		//StartCoroutine(SayHelloFiveTimes());
		//StartCoroutine(SayHello5Times());
//		StartCoroutine(SayHelloEveryFrame());

		//StartCoroutine( CountSeconds() );

//		StopAllCoroutines();

		StartCoroutine( "FirstTimer" );
		StartCoroutine( "SecondTimer" );
		//StopCoroutine(  "FirstTimer" );
		StopCoroutine(  "SecondTimer" );
	}

	IEnumerator FirstTimer()
	{
		yield return 0;
		Debug.Log("FirstTimer");
	}
	IEnumerator SecondTimer()
	{
		yield return 0;
		Debug.Log("SecondTimer");
	}

	IEnumerator CountSeconds()
	{
		int seconds = 0;
		
		while(true)
		{
			for(float timer = 0; timer < 1; timer += Time.deltaTime)
				yield return 0;
			
			seconds++;
			Debug.Log(seconds +" seconds have passed since the Coroutine started.");
		}
	}
	//Once started, this will run until manually stopped or the object is destroyed
	IEnumerator SayHelloEveryFrame()
	{
		while(true)
		{
			//1. Say hello
			Debug.Log("Hello");
			
			//2. Wait until next frame
			yield return 0;
			
		}//3. This is a forever-loop, goto 1
	}
	IEnumerator countdown()
	{
		for(float timer = 3; timer >= 0; timer -= Time.deltaTime)
		{
			count_coroutine ++;
			Debug.Log(Time.deltaTime);
			yield return 0;
			//注意：用0或者null来yield的意思是告诉协程等待下一帧，直到继续执行为止。当然，同样的你可以继续yield其他协程，我会在下一个教程中讲到这些。

		}
		
		Debug.Log("This message appears after 3 seconds!");
		Debug.Log("The coroutine count is " + count_coroutine);

	}
	//This will say hello 5 times, once each frame for 5 frames
	IEnumerator SayHelloFiveTimes()
	{
		yield return 0;
		Debug.Log("Hello");
		yield return 0;
		Debug.Log("Hello");
		yield return 0;
		Debug.Log("Hello");
		yield return 0;
		Debug.Log("Hello");
		yield return 0;
		Debug.Log("Hello");
	}
	
	//This will do the exact same thing as the above function!
	IEnumerator SayHello5Times()
	{
		for(int i = 0; i < 5; i++)
		{
			Debug.Log("Hello");
			yield return 0;
		}
	}
	void sample1(){
		timer -= Time.deltaTime;
		if(timer <= 0)
			Debug.Log("Timer has finished!");
	}
	void sample2(){
		firstTimer -= Time.deltaTime;
		if(firstTimer <= 0)
			Debug.Log("First timer has finished!");
		
		secondTimer -= Time.deltaTime;
		if(secondTimer <= 0)
			Debug.Log("Second timer has finished!");
		
		thirdTimer -= Time.deltaTime;
		if(thirdTimer <= 0)
			Debug.Log("Third timer has finished!");	
	}

	void sample3(){
		for(float timer = 3; timer >= 0; timer -= Time.deltaTime)
		{
		}
		Debug.Log("This happens after 5 seconds!");
	}

	void Update () {
		//		sample1();
		//		sample2();
		//		sample3();

		
		
	}
}
