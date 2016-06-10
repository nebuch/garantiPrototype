using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class panelOn : MonoBehaviour {
	public bool _on;
	public Image _panelImage;
	public Text _panelText;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (!_on) {
		
			_panelImage.enabled = false;
			_panelText.enabled = false;
		
		}

		if (_on) {

			_panelImage.enabled = true;
			_panelText.enabled = true;

		}

	}

	public void PanelOn(){
	
		_on = true;
	
	}
}
