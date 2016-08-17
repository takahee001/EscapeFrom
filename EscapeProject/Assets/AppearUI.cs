using UnityEngine;
using System.Collections;

public class AppearUI : MonoBehaviour {
	private Vector3 UIpos;

	// Use this for initialization
	void Start () {
		UIpos = transform.localPosition;
		print ("hoge5");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void appearUI(){

		print ("hoge4");
		UIpos.x -= 10000;
		transform.localPosition = UIpos;
	}

}
