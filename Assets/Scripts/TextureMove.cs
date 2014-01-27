using UnityEngine;
using System.Collections;

public class TextureMove : MonoBehaviour {
	public float scrollSpeed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		renderer.material.SetTextureOffset("_MainTex", new Vector2(-Time.time /scrollSpeed,0));
	}
}
