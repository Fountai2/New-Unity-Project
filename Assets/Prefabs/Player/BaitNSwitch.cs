using UnityEngine;
using System.Collections;

public class BaitNSwitch : MonoBehaviour {
	public GameObject Cube;
	public GameObject Sphere;
	public bool isCube = false;
	Vector3 playerPos;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {


	if(Input.GetKeyDown (KeyCode.W) && isCube != true)
		{
			//Debug.Log("Make a Cube");
			playerPos = Sphere.transform.position;
			Sphere.rigidbody.velocity = Vector3.zero;
			Sphere.SetActive(false);
			Cube.SetActive(true);
			Cube.transform.position = playerPos;
			isCube = true;
		} else
	if(Input.GetKeyDown (KeyCode.W) && isCube == true)
		{
			//Debug.Log("Make a Sphere");
			playerPos = Cube.transform.position;
			Cube.SetActive(false);
			Sphere.SetActive(true);
			Sphere.transform.position = playerPos;
			isCube=false;
		}


	}

	/*void OnTriggerEnter(Collider other)
	{

		if (other.gameObject.tag == "Player")
		{
			currentCubePos = other.gameObject.transform.position;
			Debug.Log(currentCubePos);
			other.gameObject.SetActive(false);
			Debug.Log("Cube deactivate");
			
		} 
		
	}*/

	}


