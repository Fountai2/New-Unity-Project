using UnityEngine;
using System.Collections;

public class Switch : MonoBehaviour {
	public GameObject sphereObstacle;
	public GameObject cubeObstacle;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(cubeObstacle.activeInHierarchy)
		{
			sphereObstacle.SetActive(false);
		} 
		if(!cubeObstacle.activeInHierarchy)
		{
			sphereObstacle.SetActive(true);
		} 
		 if(sphereObstacle.activeInHierarchy)
		{
			cubeObstacle.SetActive(false);
		}
		if(!sphereObstacle.activeInHierarchy)
		{
			cubeObstacle.SetActive(true);
		}
	}
}
