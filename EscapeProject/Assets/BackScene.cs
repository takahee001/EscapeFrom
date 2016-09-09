using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class BackScene : MonoBehaviour {
	private LayerMask mask;
	public Text t4;
	//private GameObject obj;
	//public GameObject Sphere;
	// Use this for initialization

	public void toMainScene()
	{
		SceneManager.LoadScene ("Room1");
		//if(TappedBallNum == 0){
	}
	void Start () {
		if (Manager.TappedKeyNum == 1) {
			t4.text = "You have a Key";
		}

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Ray mouseRay = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;
			mask = 1;
			if (Physics.Raycast (mouseRay, out hit, 1000.0f, mask)) {
				if (hit.collider.name == "Hole2") {
					toMainScene ();
			}
		}

	}
}
}



