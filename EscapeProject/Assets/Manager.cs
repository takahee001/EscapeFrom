using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Manager : MonoBehaviour {
	//Variables
	//Private
	static int TappedBallNum;
	static int TappedStickNum;
	static int TappedCubeNum;
	static int TappedTriangleNum;

	//Public
 	public Text score;
	public Text t1;
	public Text t2;
	public Text t3;


	// Use this for initialization
	void Start () {
		//t.text = "Number of Balls :" + TappedBallNum.ToString();
		score.text = "Number of Balls :" + TappedBallNum.ToString();

		t1.text = "Number of Triangles :" + TappedTriangleNum.ToString();
		t2.text = "Number of Sticks :" + TappedStickNum.ToString();
		t3.text = "Number of Cubes :" + TappedCubeNum.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void addTappedBallNum() {
		TappedBallNum++;
		print ("hoge");
		score.text = "Number of Balls :" + TappedBallNum.ToString();
	}
	public void addTappedCubeNum() {
		TappedCubeNum++;
		print ("hoge");
		t3.text = "Number of Cubes :" + TappedCubeNum.ToString();
	}
	public void addTappedTriangleNum() {
		TappedTriangleNum++;
		print ("hoge");
		t1.text = "Number of Triangles :" + TappedTriangleNum.ToString();
	}
	public void addTappedStickNum() {
		TappedStickNum++;
		print ("hoge");
		t2.text = "Number of Sticks :" + TappedStickNum.ToString();
	}

}
