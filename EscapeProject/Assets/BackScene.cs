using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class BackScene : MonoBehaviour {
	private LayerMask mask;
	//private GameObject obj;
	//public GameObject Sphere;
	// Use this for initialization

	public void toMainScene()
	{
		SceneManager.LoadScene ("Room1");
		//if(TappedBallNum == 0){
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
				if (hit.collider.name == "Hole2") {
					toMainScene ();

			}
		}

	}
}
}



