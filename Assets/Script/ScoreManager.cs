using UnityEngine;
using System.Collections;

public class ScoreManager : SingletonMonobehaviour<ScoreManager>
{

	private int score;

	public void Awake ()
	{
		if (this != Instance) {
			Destroy(this);
			return;
		}
		DontDestroyOnLoad(this.gameObject);
	}

	public void Start() {
		Reset();
	}

	public void Reset() {
		score = 0;
	}

	public void Set (int _score) {
		this.score = _score;
	}

	public void Add(int _score) {
		this.score += _score;
		Save ();
	}

	public int Get() {
		return score;
	}

	public ScoreManager Load() {
		this.score = PlayerPrefs.GetInt ("score");
		return this;
	}

	public ScoreManager Save() {
		PlayerPrefs.SetInt ("score", score);
		UpdateBest (score);
		return this;
	}

	public int GetBest() {
		int result = PlayerPrefs.GetInt ("score.best");
		return (result <= 0) ? 0 : result;
	}

	public void UpdateBest(int score) {
		int bestScore = GetBest();
		if (bestScore < score) {
			PlayerPrefs.SetInt ("score.best", score);
		}
	}
}
