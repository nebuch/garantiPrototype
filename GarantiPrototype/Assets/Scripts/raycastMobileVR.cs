using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class raycastMobileVR : MonoBehaviour {

	private RaycastHit hit;
	public Transform fadeToWhite;
	private string doorName;
	public string _doorDestination;
	public Transform audioDoor;
	public Transform audioAngels;
	private bool doorHasBeenClicked = false;

	// unused? 
	//private float newHitTime;
	//private Transform lastHit;
	//private Renderer circleLoader;
	

	void Start () {	
		fadeToWhite.GetComponent<Animator>().Stop();
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

			if (hit.transform.tag == "door" && doorHasBeenClicked == false) {
				//doorName = hit.transform.name;
				if (Input.GetKey("space") || Input.GetMouseButton(0)) {
					Debug.Log("CLICK! on DOOR");
					doorHasBeenClicked = true;
					hit.transform.GetComponent<Animation>().Play();
					//fadeToWhite.GetComponent<Animator>().Play("fade-to-white-3");  // does not work!
					//fadeToWhite.GetComponent<Animator>().PlayInFixedTime("fade-to-white-3");  // also does not work
					audioDoor.GetComponent<AudioSource>().Play();
					audioAngels.GetComponent<AudioSource>().Play();
					Invoke ("LoadScene", 4f);
				}
			}
		} // end of Raycast
	} // end of Update()

	void LoadScene () {
		
			SceneManager.LoadScene(_doorDestination);

	} // end of LoadScene()
}
