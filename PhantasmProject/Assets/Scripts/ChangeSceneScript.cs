using UnityEngine;
using System.Collections;

public class ChangeSceneScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public static void ChangeScene(){
		Debug.Log ("Scenechange");
		if (Application.loadedLevel == 0) {
			Application.LoadLevel(1);
		}
		if (Application.loadedLevel == 1) {
			Application.LoadLevel(0);
		}


	}

	public void ChangeSceneForButton(){
		if (Application.loadedLevel == 1) {
			Application.LoadLevel (0);
		}
	}
}
