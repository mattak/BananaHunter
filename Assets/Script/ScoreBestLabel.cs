using UnityEngine;
using System.Collections;

public class ScoreBestLabel : MonoBehaviour {
	public UILabel label;

	// Use this for initialization
	void Start () {
		ScoreManager.Instance.Load ();
	}
	
	// Update is called once per frame
	void Update () {
		label.text = "Best Score: " + ScoreManager.Instance.GetBest ();
	}
}
