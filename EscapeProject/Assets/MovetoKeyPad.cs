using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class MovetoKeyPad : MonoBehaviour {
	private LayerMask mask;
	// Use this for initialization

	private void to2DScene()
	{
		SceneManager.LoadScene ("KeyPad");
	}
	void Start () {


	}

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Ray mouseRay = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;
			mask = 1;
			if (Physics.Raycast (mouseRay, out hit, 1000.0f, mask)) {
				if (hit.collider.name == "KeyPad") {
					to2DScene ();

				}
			}
		}

	}
}
