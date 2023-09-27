using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basket : MonoBehaviour
{
  private Vector3 dir = Vector3.left;
  public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.position.x > (Screen.width / 2))
            {
                dir = Vector3.right;
                transform.Translate(dir*speed*Time.deltaTime);
            }
            if (touch.position.x < (Screen.width / 2))
            {
                dir = Vector3.left;
                transform.Translate(dir*speed*Time.deltaTime);
            }
        }
    }
}
