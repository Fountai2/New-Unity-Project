using UnityEngine;
using System.Collections;

public class TriggerActivateCube : MonoBehaviour {

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
			other.gameObject.SetActive(false);
			Debug.Log("Cube hit");
			
		} 
		if (gameObject.tag == "Sphere") 
		{
			Debug.Log("Sphere hit");
		}
	}
}
