using UnityEngine;
using System.Collections;

public class EditPaneManager : MonoBehaviour {
	public GameObject lookCamera;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (comboPressed (KeyCode.LeftControl, KeyCode.N)) {
			// spawn new window
			Vector3 pos = lookCamera.transform.position + lookCamera.transform.forward * 3;
			GameObject pane = Instantiate(Resources.Load("EditorPane"), pos, lookCamera.transform.rotation) as GameObject;
			pane.GetComponentInChildren<Canvas>().worldCamera = lookCamera.GetComponent<Camera>();
		}

		if (comboPressed (KeyCode.K, KeyCode.L)) {
			Vector3 pos = lookCamera.transform.position + lookCamera.transform.forward * 3;
			Instantiate(Resources.Load("tile"), pos, new Quaternion());
		}
	}

	public bool comboPressed(KeyCode meta, KeyCode key) {
		if (Input.GetKey (meta) && Input.GetKeyDown (key)) {
			return true;
		}
		return false;
	}
}
