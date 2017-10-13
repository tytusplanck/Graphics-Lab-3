using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle : MonoBehaviour {

	public Vector3 velocity = new Vector3(1, 1, 0);
	public GameObject particle;
	float gravity = 9.8f;

	// Use this for initialization
	void Start () {
		//GameObject ball = Instantiate(particle);
		particle.transform.parent = transform;
		particle.transform.localPosition = new Vector3(0, 100, 0);
	}
	    
	// Update is called once per frame
	void Update () {
	
		velocity.y -= gravity * Time.deltaTime;
		transform.position += velocity * Time.deltaTime;
		        
	}

}
