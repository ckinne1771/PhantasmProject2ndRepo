using UnityEngine;
using System.Collections;

public class BulletMovement : MonoBehaviour {

	public float bulletSpeed = 20.0f;
	// Use this for initialization

	// Update is called once per frame
	void Update () {
		transform.Translate (Vector2.up * bulletSpeed * Time.deltaTime);
	}
}
