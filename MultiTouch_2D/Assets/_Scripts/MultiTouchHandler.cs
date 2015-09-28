using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MultiTouchHandler : MonoBehaviour {

    public Text debugText;
    public bool debug;
    public GameObject spawnItem;

	public float persZoomSpd = 0.5f;
	public float orthoZoomSpd = 0.5f;

	// Use this for initialization
	void Start () {
        this.debug = true;
        this.debugText.text = "";
	}
	
	// Update is called once per frame
	void Update () {
        var tapCount = Input.touchCount;

		if (tapCount == 2)
		{
			//get 2 touches
			var touch1 = Input.GetTouch(0);
			var touch2 = Input.GetTouch(1);

			Vector2 touch1prev = touch1.position - touch1.deltaPosition;
			Vector2 touch2prev = touch2.position - touch2.deltaPosition;

			float prevTouchMag = (touch1prev - touch2prev).magnitude;
			float touchDeltaMag = (touch1.position - touch2.position).magnitude;

			float deltaMagDiff = (prevTouchMag - touchDeltaMag);

			this.spawnItem.transform.localScale *= deltaMagDiff;

		}
	}
}
