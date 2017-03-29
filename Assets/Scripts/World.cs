using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[ExecuteInEditMode]
public class World  {
	public int[] world;
	string path = "level/";
	public int worldSizeX, worldSizeY, worldResolution ;
	public enum ground_types
	{
		ground ,
		water 
	}

	public World () {
		
		Texture2D map = (Texture2D) Resources.Load (path + "level-1") as Texture2D ;

		this.world =  generateLevel (map);


// old way to generate ground 
//		world = new int[worldSize];
//		for (int x =0; x < worldSize; x++  ){
//			world [x] = (int) ground_types.ground;
//		}
	}

	public int[] generateLevel(Texture2D map){
		world = new int[map.width * map.height] ; 
		worldSizeX = map.width;
		worldSizeY = map.height;
		worldResolution= map.width * map.height ;
		for (int x = 0; x < map.width ; x++) {
			for (int y = 0; y < map.height; y++) {

				Color[] pixels = map.GetPixels ();
                //Debug.Log ( " X: " + x + " Y: " + y + " Color: " + pixels[x + y *map.width ].GetHashCode());
                //TODO: Switch statement 
                if (pixels[x + y * map.width] == Color.black)
                {
                    world[x + y * map.width] = -1;
                }

                else if (pixels[x + y * map.width] == Color.green)
                {

                    world[x + y * map.width] = 0;
                }
                else if (pixels[x + y * map.width] == Color.blue)
                {

                    world[x + y * map.width] = 1;
                }
                else if (pixels[x + y * map.width] == new Color(1f, 1f, 0f))
                {
                    world[x + y * map.width] = 2;
                }
                else if (pixels[x + y * map.width] == Color.white)
                {
                    world[x + y * map.width] = 3;
                }
                else if (pixels[x + y * map.width].GetHashCode() == -667552269)
                {
                    world[x + y * map.width] = 4;
                }
                else if (pixels[x + y * map.width].GetHashCode() == 541065216)
                {
                    world[x + y * map.width] = 5;
                }
                else {
                    Debug.Log(" X: " + x + " Y: " + y + " Color: " + pixels[x + y * map.width].GetHashCode());

                }

            }
		}

		return world;

	}
}
