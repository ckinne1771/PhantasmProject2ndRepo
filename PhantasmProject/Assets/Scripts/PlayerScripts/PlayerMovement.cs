using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	public float speed = 10.0f;
	private float minX =-10.0f;
	private float maxX = 10.0f;
	Vector3 minCam;
	Vector3 maxCam;
	// Update is called once per frame
	void Start()
	{
		minCam = Camera.main.ScreenToWorldPoint (new Vector3(15f, 15f, 0f));
		maxCam = Camera.main.ScreenToWorldPoint (new Vector3(Screen.width - 15f, Screen.height - 15f, 0f));
		Debug.Log (maxCam);
		Debug.Log (minCam);
	}


	void Update () {
	
		//mathF.Clamp(transform.position.x,minX,maxX);
		//Mathf.Clamp (transform.position.x, minX, maxX);
		//Mathf.Clamp (transform.position.x, minCamX.x, maxCamX.x);
		if (Input.GetKey (KeyCode.A)) {
			float newX = transform.position.x - 1.0f *speed*Time.deltaTime;
			transform.position = new Vector3(Mathf.Clamp (newX,minCam.x,maxCam.x), transform.position.y, transform.position.z);

		}

		if (Input.GetKey (KeyCode.D)) {
			float newX = transform.position.x + 1.0f *speed*Time.deltaTime;
			transform.position = new Vector3(Mathf.Clamp (newX, minCam.x, maxCam.x), transform.position.y, transform.position.z);
		}

		if (Input.GetKey (KeyCode.S)) {
			float newY = transform.position.y -1.0f *speed*Time.deltaTime;
			transform.position = new Vector3(transform.position.x , Mathf.Clamp (newY, minCam.y, maxCam.y), transform.position.z);
		}
		if (Input.GetKey (KeyCode.W)) {
			float newY = transform.position.y +1.0f *speed*Time.deltaTime;
			transform.position = new Vector3(transform.position.x , Mathf.Clamp (newY, minCam.y, maxCam.y), transform.position.z);
		}

	}
}
