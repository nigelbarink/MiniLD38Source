using UnityEngine;
using UnityEngine.UI;


using System;
using System.Collections;
using System.Collections.Generic;
public class GameManager : MonoBehaviour {
	// TODO: make this private
	public int points;
	List<Action> GUI ;
	public Text Score;

	public void Start(){
        Debug.Log("Has ran !");
        GUI = new List<Action>();
		GUI.Add (( )=>{Score.text = "Earned Points: " + points;});
        Debug.Log("GUI: " + GUI.Count);
    }
	public void Update (){
        
		foreach (Action update in GUI) {
			update ();
		}
	}









}