using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Key : MonoBehaviour {
	public GameObject key;
	private LayerMask mask;
	//public GameObject key;
	//public GameObject objB;
	//public static int TappedKeyNum;
	public Text t4;

	// Use this for initialization
	void Start () {
		//obj = GameObject.Find ("Manager");
		if (Manager.TappedKeyNum == 1) {
			Destroy (key);
			t4.text = "You have a Key";
		}
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0))
		{
			Ray mouseRay = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;
			mask = 1;
			if (Physics.Raycast (mouseRay, out hit, 1000.0f, mask)) {
				if (hit.collider.name == "Key") {
					//objB.SendMessage ("Secall");
					Manager.TappedKeyNum++;
					t4.text = "You have a Key";
					Destroy (key);
				}
			}
		}
	}
}
