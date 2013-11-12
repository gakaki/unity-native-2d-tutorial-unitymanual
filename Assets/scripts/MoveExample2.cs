using UnityEngine;
using System.Collections;

public class MoveExample2 : MonoBehaviour {

	public Vector3[] path;
	public float moveSpeed;
	
	void Start()
	{
		StartCoroutine(MoveOnPath(true));
	}
	
	IEnumerator MoveOnPath(bool loop)
	{
		do
		{
			foreach(var point in path)
				yield return StartCoroutine(MoveToPosition(point));
		}
		while(loop);
	}
	
	IEnumerator MoveToPosition(Vector3 target)
	{
		while(transform.position != target)
		{
			transform.position = Vector3.MoveTowards(transform.position, target, moveSpeed * Time.deltaTime);
			yield return 0;
		}
	}
}
