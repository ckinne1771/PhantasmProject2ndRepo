using UnityEngine;
using System.Collections;

public class EnemyHorizontalSpawnScript : MonoBehaviour {
	
	public GameObject enemyPrefab;
	GameObject Clone;
	private float timer =4.0f;
	Vector3 horizSpawnPos;
	// Use this for initialization
	void Start () {
		
		
	} 
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		if(timer<=0) 
		{
			horizSpawnPos = new Vector3 (transform.position.x, Random.Range (Camera.main.ScreenToWorldPoint (new Vector3(0, 0, 0)).y, Camera.main.ScreenToWorldPoint (new Vector3(0, Screen.height, 0)).y)
			                           ,  transform.position.z);
			
			Clone = (Instantiate (enemyPrefab, horizSpawnPos, transform.rotation)) as GameObject;
			timer=4.0f; 
		}
	} 
}
 