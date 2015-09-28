using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ItemDestroy : MonoBehaviour {

	public float destroyTime;
	public float explodeForce;

	// items to be pushed away
	public List<GameObject> touchingItems;

	// Use this for initialization
	void Start () {
	
	}

	public void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag != "Scenery")
		{
			touchingItems.Add(col.gameObject);
		}
	}

	public void OnCollisionExit2D(Collision2D col)
	{
		if (touchingItems.Contains(col.gameObject))
		{
			touchingItems.Remove(col.gameObject);
		}
	}

	// Update is called once per frame
	void Update () {
		StartCoroutine(Destroy());
	}

	public IEnumerator Destroy()
	{
		yield return new WaitForSeconds(destroyTime);

		for (int i = 0; i < touchingItems.Count; i++)
		{
			if (touchingItems[i] != null){
				Vector2 explodeV = new Vector2(
					this.transform.position.x - this.touchingItems[i].gameObject.transform.position.x,
					this.transform.position.y - this.touchingItems[i].gameObject.transform.position.y
					);

				Rigidbody2D rb = touchingItems[i].gameObject.GetComponent<Rigidbody2D>();

				if (rb != null){
					rb.AddForce(explodeV * explodeForce);
				}
			}

		}

			Destroy(this.gameObject);
	}
}
