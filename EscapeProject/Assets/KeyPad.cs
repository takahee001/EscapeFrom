using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class KeyPad : MonoBehaviour {
	private int count = 0;
	public GameObject keyPad;
	public GameObject UI;
	public static int destroied;
	// Use this for initialization

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.C)) {
			count++;
			if (count == 2) {
				count = 0;
			}
		}
		if (Input.GetKeyDown (KeyCode.B)) {
			count++;
			if (count == 2) {
				if (MoveCamera.moved == 1) {
					if (destroied == 0) {
						Destroy (keyPad);
						Destroy (UI);
						destroied = 1;
					}
				}
			}
			if (count != 2) {
				count = 0;
			}			
		}
	}
}