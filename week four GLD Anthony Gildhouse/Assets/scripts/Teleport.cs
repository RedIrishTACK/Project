using UnityEngine;
using System.Collections;

public class Teleport : MonoBehaviour {
	
	public GameObject destination;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter(Collider player) {
		player.transform.position = destination.transform.position;
	}
}