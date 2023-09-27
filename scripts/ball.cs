using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
      if(gameObject.tag == "enemy"){
          GameObject.Find("GameManager").GetComponent<GameManager>().Dead();
          Destroy(gameObject);
      }
      if (other.gameObject.tag == "addScore") 
      {
          GameObject.Find("GameManager").GetComponent<GameManager>().ScoreUp();
          Destroy(gameObject);
      }
    }

    private void OnMouseDown()
    {
      // GameObject.Find("GameManager").GetComponent<GameManager>().ScoreUp();
      // Destroy(gameObject);
    }

}
