using UnityEngine;
using System.Collections;

public class Follow : MonoBehaviour {
	public GameObject player;
	public Vector3 offset;
	
	// Update is called once per frame
	void Update () {
		offset = new Vector3 (2, 0, 0);
		Vector3 position = this.transform.position;
		position += Camera.main.transform.position - (player.transform.position - offset);
		this.transform.position = position;

	}
}
