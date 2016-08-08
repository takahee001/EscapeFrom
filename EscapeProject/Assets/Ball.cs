using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
	//Variables
	private GameObject obj;
	private LayerMask mask;
	public GameObject Sphere;
	public GameObject objB;

	// Use this for initialization

	void Start () {
		obj = GameObject.Find ("Manager");
	}

	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0))
		{
			Ray mouseRay = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;
			mask = 2;
			if(Physics.Raycast(mouseRay,out hit,1000.0f ,mask))
				{
					objB.SendMessage("Secall");
					obj.GetComponent<Manager>().addTappedBallNum();
					Destroy (gameObject);
				}
		}
	}
}
