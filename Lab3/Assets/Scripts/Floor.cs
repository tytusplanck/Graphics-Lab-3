using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour {
 
     public Terrain terrain;
     int terrainX; 
     int terrainY;
 
     public void Awake(){
         terrainX = terrain.terrainData.heightmapWidth;
         terrainY = terrain.terrainData.heightmapHeight;
         var heights = terrain.terrainData.GetHeights(0, 0, terrainX, terrainY);
 
         for (int x = 0; x < terrainX; x++) {
             for (int y = 0; y < terrainY; y++) {
                 heights[x,y] = 0;
             }
         }
         terrain.terrainData.SetHeights(0, 0, heights);
     }
 }
