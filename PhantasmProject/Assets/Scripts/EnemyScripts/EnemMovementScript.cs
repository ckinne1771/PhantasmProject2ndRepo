using UnityEngine;
using System.Collections;

public class EnemMovementScript : MonoBehaviour {
	public float speed = 5.0f;
	// Update is called once per frame
	void Update () {
		transform.LookAt (GameObject.Find ("PlayerBody").transform.position);
		transform.Translate (Vector3.forward*speed*Time.deltaTime);
	}
}
