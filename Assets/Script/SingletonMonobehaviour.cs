using UnityEngine;
using System.Collections;

public class SingletonMonobehaviour<T> : MonoBehaviour where T : MonoBehaviour {
	private static T instance;

	public static T Instance {
		get {
			if (instance == null) {
				instance = (T)FindObjectOfType(typeof(T));

				if (instance == null) {
					Debug.LogError (typeof(T) + "is nothing");
				}
			}

			return instance;
		}
	}

	// Example Implementation
	//public void Awake() {
	//	if (this != Instance) {
	//		Destroy (this);
	//		return;
	//	}
	//	DontDestroyOnLoad (this.gameObject);
	//}
}
