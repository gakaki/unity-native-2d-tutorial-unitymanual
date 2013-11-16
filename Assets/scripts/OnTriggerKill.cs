using UnityEngine;
using System.Collections;

public class OnTriggerKill : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTrigger2DEnter(Collider2D obj){
		Destroy(obj);
	}
}
