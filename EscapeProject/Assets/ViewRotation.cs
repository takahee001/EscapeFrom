using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ViewRotation: MonoBehaviour {
	private Vector3 r_pos;
	// Use this for initialization
	void Start () {
		r_pos = transform.localEulerAngles;
	}
	
	// Update is called once per frame
	void Update () {
		if (MoveCamera.moved == 0) {
			this.transform.Rotate (0, (Input.GetAxis ("Horizontal") * 1), 0);
		}
		if (MoveCamera.moved == 1) {
			r_pos.y = 0;
			transform.localEulerAngles = r_pos;
		}
	}
}
