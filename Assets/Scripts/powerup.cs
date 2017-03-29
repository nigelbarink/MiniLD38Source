using UnityEngine;
using System.Collections;

public class powerup : MonoBehaviour {
	public GameManager manager;
	public void Start(){
		manager = GameObject.Find ("Manager").GetComponent<GameManager>();
	}
	public void OnTriggerEnter2D(Collider2D other){
		manager.points += 1;
		this.gameObject.SetActive (false);
	} 
}
