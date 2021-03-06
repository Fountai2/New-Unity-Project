using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour 
{
	private GameObject moveJoy;
	private GameObject _GameManager;
	public Vector3 movement;
	public float moveSpeed = 6.0f;
	public float jumpSpeed = 5.0f;
	public float drag = 2;
	private bool canJump = true;
	public float zPos;
	void Start()
	{
		moveJoy = GameObject.Find("LeftJoystick");
		_GameManager = GameObject.Find("_GameManager");
	}

	void Update () 
	{	
		Vector3 pos = transform.position;
		pos.z = zPos;
		transform.position=pos;
		/*Vector3 forward = Camera.main.transform.TransformDirection(Vector3.forward);
		forward.y = 0;
		forward = forward.normalized;
		
		Vector3 forwardForce = new Vector3();
		if (Application.platform == RuntimePlatform.Android) 
		{
			float tmpSpeed = moveJoy.GetComponent<Joystick>().position.y;
			forwardForce = forward * tmpSpeed * 1f * moveSpeed;
		}
		else
		{
			forwardForce = forward * Input.GetAxis("Vertical") * moveSpeed;
		}
		rigidbody.AddForce(forwardForce);*/
		
		Vector3 right= Camera.main.transform.TransformDirection(Vector3.right);
		right.y = 0;
		right = right.normalized;
		
		Vector3 rightForce = new Vector3();
		if (Application.platform == RuntimePlatform.Android) 
		{
			float tmpSpeed = moveJoy.GetComponent<Joystick>().position.x;
			rightForce = right * tmpSpeed * 0.8f * moveSpeed;
		}
		else
		{
			rightForce= right * Input.GetAxis("Horizontal") * moveSpeed;
		}		
		rigidbody.AddForce(rightForce);
				
		if (canJump && Input.GetKeyDown(KeyCode.Space))
		{
			rigidbody.AddForce(Vector3.up * jumpSpeed * 100);
			canJump = false;
			_GameManager.GetComponent<GameManager>().BallJump();
		}
	}
	
	void OnTriggerEnter(Collider other) 
	{
		if (other.tag == "Destroy")
		{
			_GameManager.GetComponent<GameManager>().Death();
			Destroy(gameObject);
		}
		else if (other.tag == "Coin")
		{
			Destroy(other.gameObject);
			_GameManager.GetComponent<GameManager>().FoundCoin();
		}
		else if (other.tag == "SpeedBooster")
		{
			movement = new Vector3(0,0,0);
			_GameManager.GetComponent<GameManager>().SpeedBooster();
		}
		else if (other.tag == "JumpBooster")
		{
			movement = new Vector3(0,0,0);
			_GameManager.GetComponent<GameManager>().JumpBooster();
		}
		else if (other.tag == "Teleporter")
		{
			movement = new Vector3(0,0,0);
			_GameManager.GetComponent<GameManager>().Teleporter();
		}
    }
	
	void OnCollisionEnter(Collision collision)
	{
		if (!canJump)
		{
			canJump = true;
			_GameManager.GetComponent<GameManager>().BallHitGround();
		}
    }
	

}
