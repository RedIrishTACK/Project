using UnityEngine;
using System.Collections;

public class TeleportDoor : MonoBehaviour {
	
	public GameObject destination, player;
	public bool inDoorway = false;
	
	void Update() {
		if(Input.GetKeyDown(KeyCode.E) && inDoorway) {
			player.transform.position = destination.transform.position;
		}
	}
	
	void OnGUI() {
		if(inDoorway) {
			GUI.Box(new Rect(Screen.width/2,Screen.height/2, 75,25), "Press 'E'");
		}
	}
	
	void OnTriggerEnter(Collider other) {
		if(other.gameObject.tag == "Player") {
			inDoorway = true;
		}
	}
	
	void OnTriggerExit(Collider other) {
		if(other.gameObject.tag == "Player") {
			inDoorway = false;
		}
	}
	
	
}
