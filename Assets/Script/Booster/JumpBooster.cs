using UnityEngine;
using System.Collections;

public class JumpBooster : MonoBehaviour 
{
	public float JumpSpeed = 700f;
	
	void OnTriggerEnter  (Collider other  ) 
	{
		if (other.tag == "PlayerCube")
		{
			other.rigidbody.AddForce(Vector3.up * JumpSpeed);
		}
    }
}
