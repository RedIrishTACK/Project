using UnityEngine;
using System.Collections;

public class Instantiate : MonoBehaviour {
	
	public GameObject bullet;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButton("Fire1")) {
			Shoot();
		}
		
	}
	
	void Shoot() {
		Rigidbody clone;        // creating new variable of type Rigidbody.
		clone = Instantiate(bullet, transform.position, transform.rotation) as Rigidbody;
		clone.transform.Translate(1, 1, 0);         // make the projectile spawn in the right location (inside the gun barrel for instance.) BUT make sure it is outside of the player or it will immediately kill itself.
		clone.velocity = transform.TransformDirection(Vector3.forward * 50);       // the direction the projectile goes.
	}
}
