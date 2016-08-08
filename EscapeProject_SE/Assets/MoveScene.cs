using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class MoveScene : MonoBehaviour {

	public void toMainScene()
	{
		SceneManager.LoadScene("Room2");
	}
		

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
