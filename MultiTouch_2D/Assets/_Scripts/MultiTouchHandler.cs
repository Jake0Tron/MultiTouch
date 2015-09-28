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
            var touch = Input.GetTouch(0);

			//debugText.text = touch.position.x + " " + touch.position.y;
			
			Vector3 fingerPos = Camera.main.ScreenToWorldPoint(new Vector3(touch.position.x,touch.position.y));

            Instantiate(spawnItem, fingerPos, Quaternion.identity);
            
        }

		if (Input.GetKeyDown(KeyCode.Space))
		{
			Instantiate(spawnItem, Camera.main.ScreenToWorldPoint(new Vector3(100,100)), Quaternion.identity);
		}

	}
}
