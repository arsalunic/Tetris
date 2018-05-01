using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//public class GarbageCollector
public class GarbageCollector : MonoBehaviour {
	public float interval; 
	float time; 

	// Update is called once per physical update? 
	void FixedUpdate () {
		time += Time.fixedDeltaTime;
		if (time > interval) {
			time = 0; 
			foreach (GameObject groupBlock in GameObject.FindGameObjectsWithTag("Group")) {
				if (groupBlock.transform.GetChildCount () == 0) {
					Destroy (groupBlock); 
				}
			}
		}
	}
}
