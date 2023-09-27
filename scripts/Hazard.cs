using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazard : MonoBehaviour
{
    
    private Controls player;
    public Transform start;
    public GameObject Explode;

    void Start()
    {
        player = FindObjectOfType<Controls>();
    }
 
    void Update()
    {
    }
 
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            StartCoroutine("respawndelay");
        }
    }

    public IEnumerator respawndelay()
    {
        // Instantiate(Explode,player.transform.position, player.transform.rotation);
        Instantiate(Explode,new Vector3 (player.transform.position.x, player.transform.position.y, player.transform.position.z + 5), player.transform.rotation);
        player.enabled = false;
        player.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
        player.GetComponent<Renderer>().enabled = false;
        yield return new WaitForSeconds(1);
        // player.transform.position = start.position;
        player.transform.position = new Vector3 (start.position.x, start.position.y, start.position.z + 5);
        player.GetComponent<Renderer>().enabled = true;
        player.enabled = true;
    }
}
