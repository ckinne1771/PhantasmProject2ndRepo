using UnityEngine;
using System.Collections;

public class EnemyHorizontalSpawnScript : MonoBehaviour {
	
	public GameObject enemyPrefab;
    public GameObject fastEnemyPrefab;
    public GameObject armouredEnemyPrefab;
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

            float random = Random.value;
            if (random < 0.6)
            {
                Clone = (Instantiate(enemyPrefab, horizSpawnPos, transform.rotation)) as GameObject;
                timer = 4.0f;
            }
            if (random > 0.6 && random < 0.8)
            {
                Clone = (Instantiate(fastEnemyPrefab, horizSpawnPos, transform.rotation)) as GameObject;
                timer = 4.0f;
            }
            if (random > 0.8)
            {
                Clone = (Instantiate(armouredEnemyPrefab, horizSpawnPos, transform.rotation)) as GameObject;
                timer = 4.0f;
            }
        }
	} 
}
 