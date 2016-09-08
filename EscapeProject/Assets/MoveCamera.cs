using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MoveCamera : MonoBehaviour {
	//public GameObject KeyPad;
	private GameObject obj;
	public GameObject Key;
	private Vector3 UIpos;
	public GameObject UI;
	private LayerMask mask;
	//private int count = 0;
	private Vector3 m_pos;
	public static int moved;

	// Use this for initialization
	void Start () {
		m_pos = transform.localPosition;
		//obj = GameObject.Find ("AppearUI");
		moved = 0;
	}

	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown (0)) {
			Ray mouseRay = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;
			mask = 1;
			if (Physics.Raycast (mouseRay, out hit, 10000f, mask )) {
				if (hit.collider.name == "KeyPad") {
					if (moved == 1) {
						//print ("hoge4");
						m_pos.z -= 400f;
						m_pos.x += 100f;
						transform.localPosition = m_pos;  // 形状位置を更新
						//obj.GetComponent<ViewRotation>().enabled = true;
						moved++;
						UIpos.x = 0;
						UIpos.y = 0;
						UI.transform.position = UIpos;
						//obj.GetComponent<AppearUI> ().cutout ();
					}

					if (moved == 0) {
						//print ("hoge3");
						//ConstantForce
						m_pos.z += 400f;
						m_pos.x -= 100f;
						transform.localPosition = m_pos;  // 形状位置を更新
						//obj.GetComponent<ViewRotation>().enabled = false;   //できなかった・・
						moved++;
						UIpos.x = 1051;
						UIpos.y = 237;
						UI.transform.position = UIpos;
						//obj.GetComponent<AppearUI> ().cutin();
					}
					if (moved == 2) {
						moved = 0;
					}
				}
				if(hit.collider.name == "Key") {
						if (moved == 1) {
							//print ("hoge4");
							m_pos.z -= 400f;
							m_pos.x += 100f;
							transform.localPosition = m_pos;  // 形状位置を更新
							moved++;
						if (KeyPad.destroied == 0) {
							UIpos.x = 0;
							UIpos.y = 0;
							UI.transform.position = UIpos;
						}
							//obj.GetComponent<AppearUI> ().cutout ();
						}

						if (moved == 0) {
							//print ("hoge3");
							//ConstantForce
							m_pos.z += 400f;
							m_pos.x -= 100f;
							transform.localPosition = m_pos;  // 形状位置を更新
							moved++;
						if (KeyPad.destroied == 0) {
							UIpos.x = 1051;
							UIpos.y = 237;
							UI.transform.position = UIpos;
						}
							//obj.GetComponent<AppearUI> ().cutin();
						}
					if (moved == 2) {
						moved = 0;
					}
				}
			}
		}
	}
}
