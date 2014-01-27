using UnityEngine;
using System.Collections;

public class TriggerActivateCube : MonoBehaviour {
	public Vector3 currentCubePos;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Cube")
		{
			currentCubePos = other.gameObject.transform.position;
			Debug.Log(currentCubePos);
			other.gameObject.SetActive(false);
			Debug.Log("Cube deactivate");
			
		} 

	}
}
