using UnityEngine;
using System.Collections;

public class Cube : MonoBehaviour {
	//Variables
	private GameObject obj;
	private LayerMask mask;
	public GameObject Box;
	public GameObject objB;
	public static int Room1Cube;
	public static int Room2Cube;

	// Use this for initialization

	void Start () {
		//DontDestroyOnLoad(this);
		obj = GameObject.Find ("Manager");
		if (Room1Cube == 1) {
			if (Box.GetComponent<Collider> ().tag == "Room1") {
				Destroy (gameObject);
			}
		}
		if (Room2Cube == 1) {
			if (Box.GetComponent<Collider> ().tag == "Room2") {
				Destroy (gameObject);
			}
		}
	}

	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0))
		{
			Ray mouseRay = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;
			mask = 1;
			if(Physics.Raycast(mouseRay,out hit,1000.0f ,mask))
			{
				if (hit.collider.name == "Cube") {
					objB.SendMessage ("Secall");
					obj.GetComponent<Manager> ().addTappedCubeNum ();
					Destroy (gameObject);
					if (hit.collider.tag == "Room1") {
						Room1Cube++;
					}
					if (hit.collider.tag == "Room2") {
						Room2Cube++;
					}
				}
			}
		}
	}
}
