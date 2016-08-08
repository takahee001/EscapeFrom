using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Manager : MonoBehaviour {
	//Variables
	//Private
	int TappedBallNum;

	//Public
 	public Text score;
	public Text t1;
	public Text t2;
	public Text t3;


	// Use this for initialization
	void Start () {
		TappedBallNum = 0;
		//t.text = "Number of Balls :" + TappedBallNum.ToString();
		score.text = "Number of Balls :" + TappedBallNum.ToString();

		t1.text = "t1";
		t2.text = "t2";
		t3.text = "t3";
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void addTappedBallNum() {
		TappedBallNum++;
		print ("hoge");
		score.text = "Number of Balls :" + TappedBallNum.ToString();
	}

}
