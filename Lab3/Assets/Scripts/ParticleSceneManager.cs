using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSceneManager : MonoBehaviour {

	public Floor floorPrefab;
	private Floor floor;
	public Particle particlePrefab;
	private Particle ball;
	public int particleCount = 0;
	// Use this for initialization
	void Start () {
		floor = Instantiate(floorPrefab) as Floor;
		int i = 0;
		if (particleCount == 0) {
			while (i < 30) {
				createParticle ();
				i++;
				particleCount++;
				delayTimer ();
			}
		} else {
			createParticle ();
		}

	}
		
	IEnumerator delayTimer() {
		yield return new WaitForSeconds(0.4f);
	}


	void createParticle() {
		ball = Instantiate(particlePrefab) as Particle;
		ball.velocity.y = Random.Range(-20f, 0);
		ball.velocity.x = Random.Range(0f, 2f);
	}


	
	// Update is called once per frame
	void Update () {
		createParticle ();
	}
}
