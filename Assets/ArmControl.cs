using UnityEngine;
using System.Collections;
[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(SphereCollider))]

	public class ArmControl : MonoBehaviour {
		public float m_speed = 0.08f;
		public float m_downspeed = 0.05f;
		public GameObject m_arm;
		public bool m_right;
		public bool m_front;
	// Use this for initialization
	void Start () {
			//クレーンオブジェクトの取得
			m_arm = GameObject.Find("Hontai");
		m_right = true;
		m_front = false;

	}
	
	// Update is called once per frame
	void Update () {
		//左右キー入力の確認（Horizontal）
		//float x = Input.GetAxis ("Horizontal");

		if (m_right == true) {
			if (Input.GetKey ("space")) {
			transform.Translate (Vector3.up * Time.deltaTime * m_speed);
				m_front = true;
			}
		}
			

		//上下キー入力の確認（Vertical）
		//float z = Input.GetAxis ("Vertical");
		if (m_front == true) {
			if (Input.GetKey ("return")) {
				m_right = false;
				transform.Translate (Vector3.left * Time.deltaTime * m_speed);
			}
			m_front = false;
		}
	}
}
