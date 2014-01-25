using UnityEngine;
using System.Collections;

public class MorphScript : MonoBehaviour {
	//public bool isCube = false;
	// Use this for initialization
	public Animation cubeToSphere;
	public Animation sphereToCube;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if(Input.GetKeyDown (KeyCode.P))
		{
			//playerPos = Sphere.transform.position;
			//Sphere.SetActive(false);
			animation.Play();
			//Cube.SetActive(true);
			//Cube.transform.position = playerPos;

		} else
			if(Input.GetKeyDown (KeyCode.Q))
		{
			//playerPos = Cube.transform.position;
			//Cube.SetActive(false);
			//Sphere.SetActive(true);
			animation.Play();
			//Sphere.transform.position = playerPos;
			//isCube=false;
		}

	}
}
