using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{

    public float move_Speed = 2.0f;
    public float bound_Y = 50f;

    public bool moving_platform_Left,
                moving_platform_Right,
                is_Breakable,
                is_Spike,
                is_Platform;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move(){
        Vector3 temp = transform.position; //this obj position
        temp.y += move_Speed *  Time.deltaTime;
        transform.position = temp;

        if(temp.y >= bound_Y){
            gameObject.SetActive(false);
        }
    }
}
