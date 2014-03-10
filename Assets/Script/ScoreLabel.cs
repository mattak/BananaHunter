using UnityEngine;
using System.Collections;

public class ScoreLabel : MonoBehaviour {
	public UILabel label;
	public string prefix;

	// Use this for initialization
	void Start () {
		label.text = "init..";
	}

	// Update is called once per frame
	void Update () {
		label.text = prefix + ScoreManager.Instance.Get();
	}
}
