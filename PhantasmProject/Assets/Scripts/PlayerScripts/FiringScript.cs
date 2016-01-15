using UnityEngine;
using System.Collections;

public class FiringScript : MonoBehaviour {
	public GameObject bulletPrefab;
	GameObject Clone;
	private float timer = 0f;   

	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		if (Input.GetKey (KeyCode.Mouse0)) {
			if(timer<=0) 
			{
			Clone = (Instantiate (bulletPrefab, transform.position, transform.rotation)) as GameObject;
				timer=0.2f;
			}
		} 
	}
}