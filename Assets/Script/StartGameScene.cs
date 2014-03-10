using UnityEngine;
using System.Collections;

public class StartGameScene : MonoBehaviour {
	public GUISkin mySkin;

	// Use this for initialization
	void Start () {
		ScoreManager.Instance.Load ();
		int score = ScoreManager.Instance.GetBest ();
		print ("best : "+score);
		ScoreManager.Instance.Set (score);
		print ("get  : "+ScoreManager.Instance.Get() );
	}
	
	// Update is called once per frame
	void Update () {
	}

	// Update GUI
	void OnGUI () {
		GUI.skin = mySkin;
	}

	// Draw Label
	void DrawLabel () {
		// rect
		Rect rect;
		{
			const int offsetHeight = -40;
			const int width = 200;
			const int height = 40;
			int left = (Screen.width - width) / 2;
			int top  = (Screen.height - height + offsetHeight) / 2;
			rect = new Rect( left, top, width, height );
		}

		GUI.Label (rect, "BANANA HANTER");
	}

	// Draw Button
	void DrawStartButton () {
		const int offsetHeight = 40;
		const int width  = 100;
		const int height = 20;
		int left   = (Screen.width - width) / 2;
		int top    = (Screen.height - height + offsetHeight) / 2;
		Rect rect  = new Rect(left, top, width, height);
		
		if ( GUI.Button (rect, "Start") ) {
			print ("Start Button Pressed");
		}
	}
}