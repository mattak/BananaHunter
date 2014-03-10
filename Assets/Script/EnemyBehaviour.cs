using UnityEngine;
using System.Collections;

public class EnemyBehaviour : MonoBehaviour {
	private const float DESTORY_TIME = .5f;

	// Use this for initialization
	void Start () {
		Destroy (this.gameObject, DESTORY_TIME);
	}
	
	// Update is called once per frame
	void Update () {
	}
}
