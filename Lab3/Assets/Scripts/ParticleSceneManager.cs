using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSceneManager : MonoBehaviour {

	public Floor floorPrefab;
	private Floor floor;
	// Use this for initialization
	void Start () {
		floor = Instantiate(floorPrefab) as Floor;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
