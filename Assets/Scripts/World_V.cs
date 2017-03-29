using UnityEngine;
using System.Collections;

//[ExecuteInEditMode]
public class World_V : MonoBehaviour {
	public GameObject[] ground_; 
	
	// Update is called once per frame
	void Start () {
//		Debug.Log ("white: " + (int) World.ground_types.ground);
//		Debug.Log ("red: " + (int) World.ground_types.water);
		deleteWorld(); // FIXME: this won't delete anything 
		 World world = new World();

		buildWorld (world);




		if (GameObject.Find ("Death") == null) {

			GameObject go = new GameObject ();
			go.transform.SetParent (this.transform);
			go.name = "Death";
			go.transform.position = this.transform.position - new Vector3 (0, 10, 0);
			go.AddComponent <death> ();
			BoxCollider2D box = (BoxCollider2D)go.AddComponent<BoxCollider2D> ();
			box.isTrigger = true;
			box.size = new Vector2 (100, 10);
		}
	}



void deleteWorld (){
	int childs = transform.childCount;
	for (int i = 0; i < transform.childCount; i++) {
            DestroyImmediate(transform.GetChild(i).gameObject);
	}
}


	void buildWorld(World world){
	for (int x = 0; x < world.worldSizeX; x++) {
		for (int y = 0; y < world.worldSizeY; y++) {
				int type = world.world [x + y * world.worldSizeX];
                if (world.world[x + y * world.worldSizeX] == -1) {
                    continue;
                }
                else if (world.world[x + y * world.worldSizeX] == 3) {
                    Instantiate(ground_[type], new Vector3(x * 0.9f, y * 0.89f, 0), Quaternion.identity);
                }
                else if (world.world[x + y * world.worldSizeX] == 5) {
                    Instantiate(ground_[type], new Vector3(x * 0.9f, y * 0.89f, 0), Quaternion.identity);

                }
                else {

                    //		Debug.Log (type);
                    GameObject go = (GameObject)Instantiate(ground_[type], new Vector3(x * 0.9f, y * 0.89f, 0), Quaternion.identity);
                    go.transform.SetParent(this.transform);
                    go.name = x + " , " + y + " Type: " + type;
                }
		}
}

}
}