using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour {
	public GameObject spawnPoint;
	public GameObject ExplosionPrefab;
	public GameObject  projectilePrefab;
	public float bulletSpeed;
	Rigidbody clone;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () 
	{
		for(var i =0; i < Input.touchCount; ++i)
		{
			if(Input.GetTouch(i).phase == TouchPhase.Began )
			{
        Debug.Log ("Hello");
				// clone = Instantiate(projectilePrefab, transform.position, transform.rotation) as Rigidbody;
				// clone.velocity = transform.TransformDirection(Vector3.forward * speed);
				//            Physics.IgnoreCollision ( projectilePrefab.collider, transform.root.collider );

        // Vector2 touchPos = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
        // Vector2 dir = touchPos - (new Vector2(transform.position.x, transform.position.y));
        // dir.Normalize ();
        // GameObject bullet = Instantiate (projectilePrefab, transform.position, Quaternion.identity)as GameObject;
        // bullet.GetComponent<Rigidbody2D> ().velocity = dir * bulletSpeed; 

			}
		}

	}
}