using UnityEngine;
using System.Collections;

public class GetterSe : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	public void Secall(){
		GetComponent<AudioSource>().Play();
	}	

	// Update is called once per frame
	void Update () {
	
	}
}
