using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	public int speed = 2;
	public int jump = 5;
	public Vector3 velocity;
	public SpriteRenderer sr;
	public Sprite left_player;
	public Sprite right_player;
	public bool jumping = false;
	Rigidbody2D rig;

	void Start(){
		rig = this.GetComponent<Rigidbody2D> ();
	}
	/// <summary>
	/// Every Graphics Update Tick
	/// </summary>
	void Update () {
	

		Vector3 position = this.transform.position;

		if (  (Input.GetKeyDown (KeyCode.Space) || Input.GetKeyDown (KeyCode.UpArrow))) {
			jumping = true;
		}
		if (Input.GetAxis ("Horizontal") > 0) {
			sr.sprite = right_player;
		} else if(Input.GetAxis ("Horizontal") < 0) {
			sr.sprite = left_player;
		}
		velocity = new Vector3(Input.GetAxis("Horizontal") * speed ,  0 ,0);
		position += velocity * Time.deltaTime;
		this.transform.position = position;
	}
	/// <summary>
	///  physics update !! 
	/// </summary>
	void FixedUpdate(){
		if (jumping) {
			rig.AddForce (new Vector2 (0, jump * 100), ForceMode2D.Force);
			jumping = false;
		}
		}
}
