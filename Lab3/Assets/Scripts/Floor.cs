using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour {

	public FloorTile tilePrefab;

	public int floorHeight = 20;
	public int floorWidth = 10;
 
     void Awake(){
         for(int x = 0; x < floorWidth; x++) { 
             for(int z = 0; z < floorHeight; z++) {                
                 FloorTile tile = Instantiate(tilePrefab, Vector3.zero, tilePrefab.transform.rotation) as FloorTile;
                 tile.transform.parent = transform;
                 tile.transform.localPosition = new Vector3(x, 0, z);
     		}
		}
	 }
 }
