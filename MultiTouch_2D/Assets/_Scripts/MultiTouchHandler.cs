using UnityEngine;
using System.Collections;

public class MultiTouchHandler : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        var tapCount = Input.touchCount;
        for (var i = 0; i < tapCount; i++)
        {
            var touch = Input.GetTouch(i);

        }
	}
}
