using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class death : MonoBehaviour {

	public void OnTriggerEnter2D(Collider2D other){
		if (other.name != "Player" && other.name != "Player(Clone)"){
			return;
		}
		Debug.Log ("You entered a death zone");
		SceneManager.LoadScene (SceneManager.GetActiveScene().name);
	}
}
