using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class crosshairRotate : MonoBehaviour {

	public float _speed;
	private float _zRotation;
	private RectTransform _image;

	// Use this for initialization
	void Start () {
		_image = this.GetComponent<RectTransform> ();
	}
	
	// Update is called once per frame
	void Update () {
	
		_zRotation -= _speed * Time.unscaledDeltaTime;
		_image.localRotation = Quaternion.Euler (0, 0, _zRotation);

	}
}
