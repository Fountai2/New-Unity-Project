using UnityEngine;
using System.Collections;

public class Switch : MonoBehaviour {
	public GameObject sphereObstacle;
	public GameObject cubeObstacle;
	public GameObject PlayerSphere;
	public GameObject PlayerCube;
	Vector3 currentPos;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () 
	{


		if(!cubeObstacle.activeInHierarchy && PlayerSphere.activeInHierarchy)
		{
			sphereObstacle.SetActive(true);
			TriggerActivateCube triggeractivatecube =GameObject.Find("PlayerSphere").GetComponent<TriggerActivateCube>();
			currentPos = triggeractivatecube.currentCubePos;
			//sphereObstacle.transform.position=currentPos;
		} else
		

		if(!sphereObstacle.activeInHierarchy && PlayerCube.activeInHierarchy)
		{
			cubeObstacle.SetActive(true);
			TriggerActivateSphere triggeractivatesphere = GameObject.Find ("PlayerCube").GetComponent<TriggerActivateSphere>();
			currentPos = triggeractivatesphere.currentSpherePos;
			cubeObstacle.transform.position = sphereObstacle.transform.position;
		}

	}
}
