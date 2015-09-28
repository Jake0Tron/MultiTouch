using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MultiTouchHandler : MonoBehaviour {

    public Text debugText;
    public bool debug;
    public GameObject spawnItem;

	// Use this for initialization
	void Start () {
        this.debug = true;
        this.debugText.text = "";
	}
	
	// Update is called once per frame
	void Update () {
        var tapCount = Input.touchCount;

        for (var i = 0; i < tapCount; i++)
        {
            var touch = Input.GetTouch(i);
            Instantiate(spawnItem, new Vector3(touch.position.x,touch.position.y), Quaternion.identity);
            
        }

	}
}
