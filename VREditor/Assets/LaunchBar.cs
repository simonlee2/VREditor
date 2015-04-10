using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LaunchBar : MonoBehaviour {
	public InputField launchBar;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.T)) {
			launchBar.ActivateInputField();
			launchBar.Select();
		}
	}
}
