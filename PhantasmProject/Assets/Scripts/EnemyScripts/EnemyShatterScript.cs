using UnityEngine;
using System.Collections;

public class EnemyShatterScript : MonoBehaviour {

	public float speed = 3.0f;
	public float minScale = 0.02f;
	public float shrinkSpeed = 2.0f;

	private float targetScale;
	private Vector3 v3Scale;
	private Vector3 lowestScale = new Vector3(0.02f, 0.02f, 0.02f);
	// Use this for initialization
	 void Start()
	{
	
		Vector3 randomdirection = new Vector3 (Random.Range (0.0f, 359.9f), Random.Range (0.0f, 359.9f), Random.Range (0.0f, 359.9f));
		transform.LookAt (randomdirection);
	}

	void Update(){
		transform.position += transform.forward * speed * Time.deltaTime;
		targetScale = minScale;
		v3Scale = new Vector3 (targetScale, targetScale, targetScale);

		transform.localScale = Vector3.Lerp (transform.localScale, v3Scale, Time.deltaTime * shrinkSpeed);

		if (transform.localScale == lowestScale) {
			Destroy (transform.parent.gameObject);
			Destroy (gameObject);

		}
	
	}




}
