using UnityEngine;
using System.Collections;

public class SpawnTimer : MonoBehaviour {

	public float spawnTimer;
	
	public static int spawnNumber = 0;
	
	//Script controll
	//Controllers that will help check if there other arrows with the same script attached. 
	//We dont want all the left arrows to react if the left arrow is pressed, only the one lowest on the screen.
	//What it will do is that it will add a number to "thisScript" via scriptXControllerTwo. As you can see this one is 
	//Always one number lower then the ScriptXController. scriptXControllerTwo will add in value as the item spawns making
	//in the case of the first spawning scriptCController will have a value of 1 scriptXControllerTwo will start with 0, but soon
	//Add in value as the script for spawning the object plays. 
	//As you your player press the arrow for that object another value adds to scriptXController meaning that only the next object
	//to spawn will be able to use the relevant arrow key. 
	//Always when an object spawns if will therefor have a scritpXController + 1 value. And the only way for it to be able to
	//react to the relevant key press, is for the privious arrow image to disapair.
	
	//Left
	public static int scriptLeftControll = 1;
	public static int scriptLeftControllTwo = 0;
	
	//Right
	public static int scriptRightControll = 1;
	public static int scriptRightControllTwo = 0;
	
	//Up
	public static int scriptUpControll = 1;
	public static int scriptUpControllTwo = 0;
	
	//Down
	public static int scriptDownControll = 1;
	public static int scriptDownControllTwo = 0;
	
	void Start () {
		spawnTimer = 0;
		
		spawnNumber = 0;
	
	}
	
	void Update () {
		
			//Debug.Log (scriptLeftControll);
		
			spawnTimer += Time.deltaTime;
		
			if(spawnTimer > 2 && spawnNumber == 0){
				spawnNumber ++;
				scriptLeftControllTwo ++;
				scriptRightControllTwo ++;
			
				GameObject go = GameObject.Find("LeftArrow");
				Spawning other = (Spawning) go.GetComponent (typeof (Spawning));
				other.spawn();
			
			
				GameObject go4 = GameObject.Find("RightArrow");
				Spawning other4 = (Spawning) go4.GetComponent (typeof (Spawning));
				other4.spawn();
				
			}
		
			if(spawnTimer > 5 && spawnNumber == 1){;
				spawnNumber ++;
				scriptUpControllTwo ++;
			
				GameObject go = GameObject.Find("UpArrow");
				Spawning other = (Spawning) go.GetComponent (typeof (Spawning));
				other.spawn();
				
			}
		
			if(spawnTimer > 8 && spawnNumber == 2){;
				spawnNumber ++;
				scriptDownControllTwo ++;
			
				GameObject go2 = GameObject.Find("DownArrow");
				Spawning other2 = (Spawning) go2.GetComponent (typeof (Spawning));
				other2.spawn();
				
			}
		
			if(spawnTimer > 10 && spawnNumber == 3){
				spawnNumber ++;
				scriptLeftControllTwo ++;
				scriptRightControllTwo ++;
			
				GameObject go = GameObject.Find("LeftArrow");
				Spawning other = (Spawning) go.GetComponent (typeof (Spawning));
				other.spawn();
			
			
				GameObject go4 = GameObject.Find("RightArrow");
				Spawning other4 = (Spawning) go4.GetComponent (typeof (Spawning));
				other4.spawn();
				
			}
		
			if(spawnTimer > 12 && spawnNumber == 4){;
				spawnNumber ++;
				scriptUpControllTwo ++;
			
				GameObject go = GameObject.Find("UpArrow");
				Spawning other = (Spawning) go.GetComponent (typeof (Spawning));
				other.spawn();
				
			}
		
			if(spawnTimer > 16 && spawnNumber == 5){;
				spawnNumber ++;
				scriptDownControllTwo ++;
			
				GameObject go2 = GameObject.Find("DownArrow");
				Spawning other2 = (Spawning) go2.GetComponent (typeof (Spawning));
				other2.spawn();
				spawnTimer = 0;
				spawnNumber = 0;
				
			}
	
	}
}
