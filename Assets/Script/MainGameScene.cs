using UnityEngine;
using System.Collections;

public class MainGameScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Invoke("GameOver", 10);
		ScoreManager.Instance.Reset ();
	}
	
	// Update is called once per frame
	void Update () {
	}

	void GameOver () {
		Application.LoadLevel("GameOverScene");
	}
}
