using UnityEngine;
using System.Collections;

public class MoveCamera : MonoBehaviour {
	private GameObject obj;
	private LayerMask mask;
	private Vector3 m_pos;
	// Use this for initialization
	void Start () {
		m_pos = transform.localPosition;
		obj = GameObject.Find ("AppearUI");
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown (0)) {
			Ray mouseRay = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;
			mask = 1;
			if (Physics.Raycast (mouseRay, out hit, 1000.0f, mask)) {
				if (hit.collider.name == "KeyPad") {
					//ConstantForce
					m_pos.z += 400f;
					m_pos.x -= 100;
					transform.localPosition = m_pos;  // 形状位置を更新
					obj.GetComponent<AppearUI>().appearUI();
				}
			}
		}
	}
}
