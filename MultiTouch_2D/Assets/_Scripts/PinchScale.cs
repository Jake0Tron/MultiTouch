using UnityEngine;
using System.Collections;

public class PinchScale : MonoBehaviour {

	public GameObject scaleItem;

	// Use this for initialization
	void Start () {
	
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

			this.scaleItem.transform.localScale *= deltaMagDiff;

		}
		else
		{
			Vector3 sizer = new Vector3(1, 1, 1);
			if (this.scaleItem.transform.localScale.x > sizer.x
			 || this.scaleItem.transform.localScale.y > sizer.y)
			{
				Vector3 sc = this.scaleItem.transform.localScale;
				sc.x *= 0.95f;
				sc.y *= 0.95f;
				sc.z *= 0.95f;
				this.scaleItem.transform.localScale = sc;
			}
			else
			{
				Vector3 sc = this.scaleItem.transform.localScale;
				sc.x *= 1.05f;
				sc.y *= 1.05f;
				sc.z *= 1.05f;
				this.scaleItem.transform.localScale = sc;
			}
		}
	}
}
