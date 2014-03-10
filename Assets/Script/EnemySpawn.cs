using UnityEngine;
using System.Collections;

public class EnemySpawn : MonoBehaviour {
	
	public GameObject enemy;
	public float time;
	private const float SPAWN_TIME  = .50f;
	private const int SPAWN_ENEMIES = 3;

	// Use this for initialization
	void Start () {
		time = .0f;
	}

	// Update is called once per frame
	void Update () {
		// Spawn with constant time.
		time += Time.deltaTime;
		if (time >= SPAWN_TIME) {
			print ("SPAWN");
			Spawn ();
			time = .0f;
		}

		// Touch GameObject to delete.
		TouchDelete();
	}

	void TouchDelete() {
		// remove enemy
		if (Input.GetMouseButtonDown(0)) {
			Vector3 mousePoint     = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 5.0f);
			Vector3 tapPoint       = Camera.main.ScreenToWorldPoint(mousePoint);
			Collider2D collider2d = Physics2D.OverlapPoint (tapPoint);
			
			Debug.Log ("TapPoint:   " + tapPoint.x + ", " + tapPoint.y + ", ... " + tapPoint.ToString());
			
			if (collider2d) {
				
				RaycastHit2D hitObject = Physics2D.Raycast (tapPoint, -Vector2.up);
				
				if (hitObject) {
					Debug.Log ("hitObject");
					HitObject(hitObject.collider.gameObject);
				}
			}
		}
	}

	void HitObject (GameObject obj) {
		ScoreManager.Instance.Add (1);
		Destroy (obj);
	}

	// generate random index.
	int RandomIndex (int begin, int end) {
		int result = (int)(Random.value * (end - begin + 1)) + begin;
		return result;
	}

	void Spawn() {
		// instantinate game object
		for (int n = 0; n < SPAWN_ENEMIES; n++) {
			float x = RandomIndex (-2, 1) + 0.5f;
			float y = RandomIndex (-2, 1) + 0.5f;
			//GameObject enemy = Resources.Load ("EnemyBanana");
			Instantiate (enemy, new Vector3(x, y, 0.0f), Quaternion.identity);
		}
	}
}
