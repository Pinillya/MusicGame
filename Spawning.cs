using UnityEngine;
using System.Collections;

public class Spawning : MonoBehaviour {
	
	public GameObject parentGameObject; 
	public GameObject Arrow;
	public Transform spawnA;  
		
	public void spawn () {
		
			GameObject go;
			go=Instantiate(Arrow,spawnA.position, spawnA.rotation) as GameObject;	
			go.transform.parent=transform;
	}
}