using UnityEngine;
using System.Collections;

public class LevelProgression : MonoBehaviour {
	public string nextLevel;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision other)
	{
		Debug.Log("POOP");
		if(other.gameObject.tag == "Player")
		{
			Application.LoadLevel(nextLevel);
		}
	}
}
