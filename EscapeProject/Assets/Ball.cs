using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
	//Variables
	private GameObject obj;

	public GameObject Sphere;

	// Use this for initialization

	void Start () {
		obj = GameObject.Find ("Manager");
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			obj.GetComponent<Manager>().addTappedBallNum();
			Destroy (gameObject);
		}
	}
}
