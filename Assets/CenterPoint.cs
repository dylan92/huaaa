using UnityEngine;
using System.Collections;

public class CenterPoint : MonoBehaviour {
	
	public Transform p1;
	public Transform p2;
	
	// Update is called once per frame
	void Update () {
		this.transform.position = ((p1.position - p2.position) * 0.5f) + p2.position;
	}
}
