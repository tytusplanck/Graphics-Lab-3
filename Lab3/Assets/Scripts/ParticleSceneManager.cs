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
		ball = Instantiate(particlePrefab) as Particle;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
