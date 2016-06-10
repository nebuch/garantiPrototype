using UnityEngine;
using System.Collections;

public class lightMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
		transform.position = Vector3(Mathf.PingPong(Time.time, 8)-4, transform.position.y, Mathf.PingPong(Time.time, 8)-4);
	}
	
	// Update is called once per frame
	void Update () {
		//this.transform.position = Vector3(Mathf.PingPong(Time.time, 8)-4, transform.position.y, Mathf.PingPong(Time.time, 8)-4);
	}
}
