using UnityEngine;
using System.Collections;

public class CreditsEnable : MonoBehaviour {
	public GameObject Credits;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnClick ()
	{
		Credits.SetActive(true);
	}
}
