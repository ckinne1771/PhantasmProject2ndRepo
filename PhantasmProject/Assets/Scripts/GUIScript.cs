using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GUIScript : MonoBehaviour {
	int scoreValue = 0;
	public Text score;

	// Use this for initialization
	void Start () {

		score.text = "Score: 0";
	}

	void Update(){
		if (EnemyCollisionScript.scoreChange == true) {
			IncreaseScore();
		}
	}
	public void IncreaseScore(){
		scoreValue++;
		score.text = "Score: " + scoreValue;
		EnemyCollisionScript.scoreChange = false;
	}
}
