using UnityEngine;
using System.Collections;

public class ScoreLabel : MonoBehaviour {
	public UILabel label;
	public string format;

	// Use this for initialization
	void Start () {
		label.text = "init..";
	}

	// Update is called once per frame
	void Update () {
		label.text = string.Format(format, ScoreManager.Instance.Get());
	}
}
