using UnityEngine;
using System.Collections;

public class KeyPad : MonoBehaviour {
	public GameObject obj;
	private int count = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.A)) {
			count++;
			if (count == 2) {
				count = 0;
			}
		}
			if (Input.GetKeyDown (KeyCode.B)) {
				count++;
				if (count == 2) {
					Destroy (gameObject);
				}
			if (count != 2) {
				count = 0;
			}
		}
	}
}
