using UnityEngine;
using System.Collections;

public class EnemySpawnScript : MonoBehaviour {

	public GameObject enemyPrefab;
	GameObject Clone;
	private float timer =4.0f;
	Vector3 topSpawnPos;
	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
			if(timer<=0) 
			{
			topSpawnPos = new Vector3 (Random.Range (Camera.main.ScreenToWorldPoint (new Vector3(0, 0, 0)).x, Camera.main.ScreenToWorldPoint (new Vector3(Screen.width, 0, 0)).x)
			                           , transform.position.y, transform.position.z);
				
				Clone = (Instantiate (enemyPrefab, topSpawnPos, transform.rotation)) as GameObject;
				timer=4.0f;
			}
		}
	}

