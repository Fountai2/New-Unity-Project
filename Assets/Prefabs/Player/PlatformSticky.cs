using UnityEngine;
using System.Collections;
public class PlatformSticky : MonoBehaviour {
	public GameObject PlayerHolder; 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collision c)
	{
		Debug.Log("I'm touching something!");
		if(c.transform.tag == "Platform")
		{
			Debug.Log("I'm on a platform!");
			PlayerHolder.transform.parent = c.transform;

		}
}

	void OnTriggerExit(Collision c)
	{
		if(c.transform.tag == "Platform")
		{
		PlayerHolder.transform.parent =null;
		
		}
	}

}
