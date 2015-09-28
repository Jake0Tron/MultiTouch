using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MultiTouchHandler : MonoBehaviour {

    public Text debugText;
    public bool debug;
    public GameObject spawnItem;

	public float coolDown = 0.05f;

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
			Vector3 fingerPos = Camera.main.ScreenToWorldPoint(new Vector3(touch.position.x, touch.position.y));

			//debugText.text = touch.position.x + " " + touch.position.y;
			if (this.coolDown < 0.0f)
			{
				Instantiate(spawnItem, fingerPos, Quaternion.identity);
				this.coolDown = 0.5f;
			}
			else
			{
				this.coolDown -= 0.01f;
			}
		}
		if (Input.GetKey(KeyCode.Space))
		{
			if (this.coolDown < 0.0f)
			{
				GameObject o = (GameObject)Instantiate(spawnItem, (new Vector3(0 , 5, 0)), Quaternion.identity);
				
				this.coolDown = 0.05f;
			}
			else
			{
				this.coolDown -= 0.01f;
			}
		}


	}
}
