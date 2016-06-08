using UnityEngine;
using System.Collections;

public class raycastMobileVR : MonoBehaviour {

	private RaycastHit hit;
	public Transform fadeToWhite;

	// unused? 
	//private float newHitTime;
	//private Transform lastHit;
	//private Renderer circleLoader;
	

	void Start () {	
	} // end of Start()
	
	
	void Update () {
		Vector3 fwd = transform.TransformDirection(Vector3.forward);  // can this be made into a normal var?

		if (Physics.Raycast(transform.position, fwd, out hit, 400)) {
			/*
			if (hit.transform != lastHit){
				if (circleLoader) {
					circleLoader.material.SetFloat("_Cutoff", 1); 
				}
				newHitTime = Time.time;
				lastHit = hit.transform;
				if (lastHit.Find ("circle loader")) {
					circleLoader = hit.transform.Find ("circle loader").GetComponent<Renderer>();
					circleLoader.material.SetFloat("_Cutoff", 1); 
				}
			}
			*/

			/*
			if (hit.transform.tag == "ui") {
				if (Time.time - newHitTime > 1) {
					circleLoader.material.SetFloat("_Cutoff", 1); 
				} else if (Time.time - newHitTime < 1){
					circleLoader.material.SetFloat("_Cutoff", 1 - (Time.time - newHitTime)); 
				} 
			} 
			*/

			if (hit.transform.tag == "door") {
				Debug.Log("raycast hits door");
				if (Input.GetKey("space")) {
					Debug.Log("space bar pressed");
					if (hit.transform.GetComponent<Animation>()) {				// check to ensure that the object has an animation attached
						hit.transform.GetComponent<Animation>().Play();
						fadeToWhite.GetComponent<Animation>().Play();
					}
				}
			}
		} // end of Raycast
	} // end of Update()
}
