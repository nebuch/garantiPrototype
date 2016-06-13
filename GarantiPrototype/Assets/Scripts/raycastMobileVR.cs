using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class raycastMobileVR : MonoBehaviour {

	private RaycastHit hit;
	//public Transform fadeToWhite;
	//private string doorName;
	private string _doorDestination;
	public Transform audioDoor;
	public Transform audioAngels;
	private bool doorHasBeenClicked = false;
    public ScreenFadeOut fadeout;
    public ScreenFadeIn fadein;


	void Start () 
	{	
		//fadeToWhite.GetComponent<Animator>().Stop();
	}
	
	
	void Update () 
	{
		Vector3 fwd = transform.TransformDirection(Vector3.forward);
		if (Physics.Raycast(transform.position, fwd, out hit, 400)) 
		{
			if (hit.transform.tag == "door" && doorHasBeenClicked == false) 
			{
				_doorDestination = hit.transform.gameObject.GetComponent<doorToGo>()._toGoScene;
				if (Input.GetKey("space") || Input.GetMouseButton(0)) 
				{
					Debug.Log("click on door");
					doorHasBeenClicked = true;
					if (hit.transform.GetComponent<Animator>()) 
					{
						hit.transform.GetComponent<Animator>().Play("default");
					}
					audioDoor.GetComponent<AudioSource>().Play();
					audioAngels.GetComponent<AudioSource>().Play();
                    Invoke ("StartFadeOut",1f);
					Invoke ("LoadScene", 4f);
				} // end of input click
			} // end of if raycast hit a "door"
		} // end of Raycast

        if(SceneManager.GetActiveScene().name == "Intro")
        {
            fadein.GetComponent<ScreenFadeIn>().enabled = true;
        }

	} // end of Update()

    void StartFadeOut()
    {
        fadeout.GetComponent<ScreenFadeOut>().enabled = true;
    }

	void LoadScene () 
	{
		SceneManager.LoadScene(_doorDestination);
	}
}
