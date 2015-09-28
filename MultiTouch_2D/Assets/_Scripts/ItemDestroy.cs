using UnityEngine;
using System.Collections;

public class ItemDestroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		StartCoroutine(Destroy());
	}

	public IEnumerator Destroy()
	{
		yield return new WaitForSeconds(3.0f);
		Destroy(this.gameObject);
	}
}
