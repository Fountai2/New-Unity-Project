using UnityEngine;
using System.Collections;

//private GameObject targetobj;

public class TriggerActivateSphere : MonoBehaviour {
	public Vector3 currentSpherePos;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other)
	{
		 GameObject tempObj;

		tempObj = other.gameObject;

		if (tempObj.tag == "Sphere")
		{
			currentSpherePos = tempObj.transform.position;
			tempObj.SetActive(false);
			Debug.Log(currentSpherePos);

		} else if (tempObj.tag == "Block"){
			tempObj.SetActive(false);
			Debug.Log ("Sphere hit");
		}
	}
}
