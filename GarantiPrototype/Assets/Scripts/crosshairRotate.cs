using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class crosshairRotate : MonoBehaviour {

	public float _speed;
	private float _rotationZ;
	public RectTransform _image;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		_image.localRotation = Quaternion.Euler (0, 0, _rotationZ);

		_rotationZ += _speed * Time.unscaledDeltaTime;
	}
}
