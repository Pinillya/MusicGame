using UnityEngine;
using System.Collections;

public class LeftFalling : MonoBehaviour {
		
	//Objects
	public Texture2D[] Arrow;
	public GUITexture ArrowGUI;
	
	//Moving
	public float fallSpeed ;
	
	//Is the arrow in place?
	private bool inPlace = false;
	private bool failed = false;
	
	//Controlling what arrow image reacts to what keypress. Please see "SpawnTimer for a more in debth explenation.
	private int thisScript;
	private float addTimer;
	
	void Start () {
		
		//UpArrowGUI.enabled = false;
		fallSpeed = -0.001f;
		
		//makes thisScript of -this script- a number that is one above the number the last arrow image had. 
		thisScript = SpawnTimer.scriptLeftControllTwo;
	
	}
	
	void Update () {	
		
		//moving
		transform.Translate(0,fallSpeed,0);
		
		
		//Here we check how the script will react if the player has not miss pressed.
		if ( failed == false){
			
			//The arrow is in position - change image to show this. - change a boolian so that the player can press a kay and get points.
			if (transform.position.y < 0.18 && transform.position.y > 0.11){
				inPlace = true;
				ArrowGUI.texture = Arrow [1];
			}
			
			//The arrow is not in position - we change the image back to normal.
			if (inPlace == false){
				ArrowGUI.texture = Arrow [0];	
			}
			
			//The player pressed the image as it was in the right position.
			if (Input.GetKeyDown(KeyCode.LeftArrow) && inPlace == true){
				Debug.Log ("Points!!!");
				ArrowGUI.enabled = false;
			}	
			
			//The arrow is no longer in the right place. 
			if (transform.position.y < 0.11){	
				inPlace = false;
			}
		}
		
		//The arrow has fallen to fare down we want it to despawn.
		if (transform.position.y < 0.04){
			ArrowGUI.enabled = false;	
		}
		
		//Here we check to see if the player has pressed when the arrow image is not in the right place. We also check if
		//this is indeed the arrow that is the furthest down right now on the screen. 
		if (Input.GetKeyDown(KeyCode.LeftArrow) && inPlace == false && SpawnTimer.scriptLeftControll == thisScript){
			Debug.Log ("fail!!!");
			failed = true;
			ArrowGUI.texture = Arrow [2];
		}
		
		//If the player has pressed an arrowKay and the image should disapair we add a timer that will regulate when the image
		//will despawn.
		if (failed == true || ArrowGUI.enabled == false){
			addTimer += Time.deltaTime;	
		}
		
		//Here the arrow image removed. We then tell the script "SpawnTimer" this by increasing the value of scriptXcontroller.
		//This will enable the next X arrow in line to be able to be pressed. 
		//The reason why we have a timer is so that the kaypress of the first arrow image wont effect the next arrow image.
		if (addTimer > 0.1){
			Debug.Log ("timer Up");	
			Destroy (gameObject);
			SpawnTimer.scriptLeftControll ++;
		}
	
	}
}
