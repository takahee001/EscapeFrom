using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class KeyPad : MonoBehaviour {
	public GameObject obj;
	private int count = 0;
	private LayerMask mask;
	// Use this for initialization

	public void toRoomScene()
	{
		SceneManager.LoadScene ("Room1");
	}

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
		if (Input.GetMouseButtonDown (0)) {
			Ray mouseRay = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;
			mask = 1;
			if (Physics.Raycast (mouseRay, out hit, 1000.0f, mask)) {
				//if (hit.collider.name == "Cube") {
					toRoomScene ();

				//}

			}
		}
	}
}