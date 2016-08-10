using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
	//Variables
	private GameObject obj;
	private LayerMask mask;
	public GameObject Sphere;
	public GameObject objB;
	public static int Room1Ball;
	public static int Room2Ball;

	// Use this for initialization

	void Start () {
		//DontDestroyOnLoad(this);
		obj = GameObject.Find ("Manager");
		if (Room1Ball == 1) {
			if (Sphere.GetComponent<Collider>().tag == "Room1") {
				Destroy (gameObject);
			}
		}
		if (Room2Ball == 1) {
			if (Sphere.GetComponent<Collider>().tag == "Room2") {
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
				if (hit.collider.name == "Ball") {
					objB.SendMessage ("Secall");
					obj.GetComponent<Manager> ().addTappedBallNum ();
					Destroy (gameObject);
					if (hit.collider.tag == "Room1") {
						Room1Ball++;
					}
					if (hit.collider.tag == "Room2") {
						Room2Ball++;
					}
				}

				}
		}
	}
}
