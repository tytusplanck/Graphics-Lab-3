using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSceneManager : MonoBehaviour {

	public Floor floorPrefab;
	private Floor floor;
    public Emitter emitterPrefab;
    private Emitter emitter;

	public int particleCount = 0;
	// Use this for initialization
	void Start () {
		floor = Instantiate(floorPrefab) as Floor;
        emitter = Instantiate(emitterPrefab) as Emitter;
	}

	// Update is called once per frame
	void Update () {
	}
}
