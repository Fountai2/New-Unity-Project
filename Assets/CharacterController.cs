using UnityEngine;
using System.Collections;

public class CharacterController : MonoBehaviour {
	public float MovementSpeed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.D))
		{
			this.transform.Rotate(10,0,0);
		} 
		if (Input.GetKeyDown (KeyCode.A)) 
		{
			this.transform.Rotate(10,0,0);
		}
	
}
}
