using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle : MonoBehaviour {

	public Vector3 velocity = new Vector3(0, 1, 0);
	public GameObject particle;
	float gravity = 9.8f;

	// Use this for initialization
	void Start () {
        particle.transform.parent = transform;
        particle.transform.localPosition = new Vector3(25, 15, 20);
    }
	    
	// Update is called once per frame
	void Update () {

		velocity.y -= gravity * Time.deltaTime;
		transform.position += velocity * Time.deltaTime;
		if (particle.transform.localPosition.y <= 0.0f && velocity.y < 0) {
			velocity.y = -velocity.y;
		}
		transform.localScale -= new Vector3(.005f,.005f,.005f);
		if (transform.localScale.x < .1) {
			Destroy(particle);
		}        
	}
}
