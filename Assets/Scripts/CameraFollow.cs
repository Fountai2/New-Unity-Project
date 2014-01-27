using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {
	public float distance;
	public float ydist;
	public float xdist;
	public GameObject playerStatus;
	public GameObject Cube;
	public GameObject Sphere;
	bool status;
	// Use this for initialization
	void Start () {
		status = true;
	}
	
	// Update is called once per frame
	void Update () {
		if(playerStatus.GetComponent<BaitNSwitch>().isCube && status)
		{
			transform.position = new Vector3(Cube.transform.position.x+xdist,Cube.transform.position.y+ydist,Cube.transform.position.z -distance);

		}
		if (!playerStatus.GetComponent<BaitNSwitch> ().isCube && status) 
				{
			transform.position = new Vector3(Sphere.transform.position.x+xdist,Sphere.transform.position.y+ydist,Sphere.transform.position.z -distance);

				}

		//transform.position = new Vector3 (player.transform.position.x, player.transform.position.y, player.transform.position.z - distance);
	
	


	}
}
