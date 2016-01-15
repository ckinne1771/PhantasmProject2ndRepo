using UnityEngine;
using System.Collections;

public class ObjectCleanup : MonoBehaviour {
	
	// Update is called once per frame
	void OnBecameInvisible()
	{
		Destroy (gameObject);
	}
}
