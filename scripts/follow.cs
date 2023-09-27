using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour {
	public float speed;
	public GameObject player;
	public Transform target;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(target != null)
		{
			transform.LookAt(target);
			transform.Translate (player.transform.position.x , player.transform.position.y , Time.deltaTime * speed);
		}
	}
}
