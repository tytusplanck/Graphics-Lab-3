using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSceneManager : MonoBehaviour {

	public Floor floorPrefab;
	private Floor floor;
	public Particle particlePrefab;
	private Particle ball;
	// Use this for initialization
	void Start () {
		floor = Instantiate(floorPrefab) as Floor;
		int i = 0;
		while (i < 20) {
			ball = Instantiate(particlePrefab) as Particle;
			ball.velocity.y = Random.Range(-20f, 0);
			ball.velocity.x = Random.Range(0f, 2f);
			i++;
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
