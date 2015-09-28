using UnityEngine;
using System.Collections;

public class EscapeHandler : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	public void LoadNextLevel()
	{
		Application.LoadLevel("TouchTest");
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.Escape)){
			Application.Quit();
		}
	}
}
